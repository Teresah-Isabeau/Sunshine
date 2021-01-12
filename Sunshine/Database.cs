using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sunshine
{
    class Database
    {
        //test test
        MySql.Data.MySqlClient.MySqlConnection conn;
        static string host = "192.168.172.20";
        static string port = "3306";
        static string databaseName = "Sunshine";
        static string userID = "TestUser";
        static string password = "P@ssword";
        private string connectionString;

        public Database()
        {
            this.connectionString = String.Format(
                "server={0};port={1};user id={2}; password={3}; database={4}",
                host,
                port,
                userID,
                password,
                databaseName);
            this.conn = new MySqlConnection(this.connectionString);
        }
        //Opent de database connectie
        private bool Open()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception er)
            {            
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        //Sluit de database connectie
        private void Close()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataTable Select(string sql)
        {
            List<MySqlParameter> emptyCollection = new List<MySqlParameter>();
            return this.Select(sql, emptyCollection);
        }

        /// <summary>
        /// Haalt data op uit de database.
        /// Voert de select query uit en zet de data in een datatable object.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        //select
        public DataTable Select(string sql, List<MySqlParameter> sqlParameters)
        {
            try
            {
                this.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                adapter.SelectCommand.CommandType = CommandType.Text;

                foreach (MySqlParameter param in sqlParameters)
                    adapter.SelectCommand.Parameters.Add(param);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                this.Close();
            }
        }

        /// <summary>
        /// Voegt data toe aan een nieuwe regel in de database en commit deze transactie.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        //insert
        public int Insert(string sql, List<MySqlParameter> sqlParameters)
        {
            int affected;
            this.Open();
            try
            {
                MySqlTransaction transaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                foreach (MySqlParameter param in sqlParameters)
                    cmd.Parameters.Add(param);
                affected = cmd.ExecuteNonQuery();
                transaction.Commit();
                return affected;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                this.Close();
            }
        }

        /// <summary>
        /// Reader checkt of de data bestaat in de database. 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        //exists
        public bool Exists(string sql, List<MySqlParameter> sqlParameters)
        {
            try
            {
                this.Open();
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                foreach (MySqlParameter param in sqlParameters)
                    cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                this.Close();
            }
        }
    }
}