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
    //ToDo: when user edits information, show the information already given in the boxes,
    //make a check to see if the variables are null,
    //if yes show blank,
    //if no show the information
    public partial class AccountInfo : Form
    {
        public static decimal age;

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

            var rez = cultures.Select(cult => (new RegionInfo(cult.LCID)).DisplayName).Distinct().OrderBy(q => q).ToList();

            return rez;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            age = nudAge.Value;

            CreateAccount.NewUser.UserInformation(tbName.Text, age, cbCountry.Text, cbSkin.Text);
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


    }
}
