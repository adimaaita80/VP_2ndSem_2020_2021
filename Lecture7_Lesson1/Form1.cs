using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7_Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Baby baby = new Baby();

            baby.FirstName = txtFirstName.Text;
            baby.MiddleName = txtMiddleName.Text;
            baby.LastName = txtLastName.Text;

            MessageBox.Show(baby.BabyInformation());
        }
    }
}
