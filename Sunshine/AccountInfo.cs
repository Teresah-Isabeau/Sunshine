using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Sunshine
{
    public partial class AccountInfo : Form
    {
        private decimal age;
        private string name;
        private string country;
        private string skintype;

        public AccountInfo()
        {
            InitializeComponent();
            foreach (string item in GetAllCountrysNames())
            {
                cbCountry.Items.Add(item);
            }
        }
        public static List<string> GetAllCountrysNames()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            var rez = cultures.Select(cult => (new RegionInfo(cult.LCID)).EnglishName).Distinct().OrderBy(q => q).ToList();

            return rez;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            age = nudAge.Value;
            name = tbName.Text;
            country = cbCountry.Text;
            skintype = cbSkin.Text;

            CreateAccount.NewUser.UserInformation(name, age, country, skintype);
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(cbCountry.Text) || nudAge == null || string.IsNullOrWhiteSpace(cbSkin.Text)) {
                MessageBox.Show("Please fill in every field");
            }
            else
            {
                this.Hide();
                Home form5 = new Home();
                form5.Show();
            }
            
        }
        private void AccountInfo_Load(object sender, EventArgs e)
        {
            if (Home.countdownTimer != null)
            {
                Home.countdownTimer.Enabled = false;

            }
        }
    }
}
