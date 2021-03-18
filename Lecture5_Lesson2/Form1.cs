using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture5_Lesson2
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("This form was loaded successfully");
            txtEmployeeNo.Text = "IU" + DateTime.Now.Year.ToString() + "0" + 1;

            InitCountries();
            InitCities();
        }

        private void InitCountries()
        {
            cbCountries.Items.Add("Jordan");
            cbCountries.Items.Add("Iraq");
            cbCountries.Items.Add("Syria");
            cbCountries.Items.Add("Egypt");
            cbCountries.Items.Add("United Kingdom");
        }

        private void InitCities()
        {
            cbCities.Items.Add("Amman");
            cbCities.Items.Add("Baghdad");
            cbCities.Items.Add("London");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /* We will read all the data from the form and display it */
            string empNo = txtEmployeeNo.Text;

            string name = $"{txtFirstName.Text} {txtMiddleName.Text} {txtLastName.Text}";

            string gender = "";
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";
            else
                gender = "Not Selected";

            string address = $"Country: {cbCountries.SelectedItem}, City: {cbCities.SelectedItem}, Street: {txtStreet.Text}";

            string result = empNo + "\n" + name + "\n" + gender + "\n" + address;

            MessageBox.Show(result);
        }
    }
}
