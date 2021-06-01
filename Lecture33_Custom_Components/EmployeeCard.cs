using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture33_Custom_Components
{
    public partial class EmployeeCard : UserControl
    {
        public string EmployeeName
        {
            get { return txtEmployeeName.Text; }
            set { txtEmployeeName.Text = value; }
        }
        public string EmployeeEmail 
        {
            get { return txtEmployeeEmail.Text; }
            set { txtEmployeeEmail.Text = value; } 
        }
        public string EmployeePhone
        {
            get { return txtEmployeePhone.Text; }
            set { txtEmployeePhone.Text = value; }
        }
        public EmployeeCard()
        {
            InitializeComponent();
        }

        private void btnDisplayMessage_Click(object sender, EventArgs e)
        {
            string mySummary = $"Name: {EmployeeName} \n Email: {EmployeeEmail} \n Phone: {EmployeePhone}";
            MessageBox.Show(mySummary);
        }
    }
}
