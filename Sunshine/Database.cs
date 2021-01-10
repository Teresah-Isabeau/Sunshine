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
    /*class Database
    {
        public static void Test()
        {
            string connStr = "server=192.168.172.20;user id=TestUser;database=Sunshine";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                // Perform database operations
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }*/

    class connection
    {

        MySql.Data.MySqlClient.MySqlConnection conn;
        static string host = "192.168.172.20";
        static string port = "3306";
        static string database = "Sunshine";
        static string userID = "TestUser";
        static string password = "P@ssword";
        private string connectionString;

        public connection()
        {
            this.connectionString = String.Format(
                "server={0};port={1};user id={2}; password={3}; database={4}",
                host,
                port,
                userID,
                password,
                database);
            this.conn = new MySqlConnection(this.connectionString);
        }

        private bool Open()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                //return false;
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }

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
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                this.Close();
            }
        }

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
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                this.Close();
            }
        }

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
            catch (Exception ex)
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