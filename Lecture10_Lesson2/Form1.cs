using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture10_Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This form has loaded");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("This form is closing");
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            //this.Close(); // closes the current form
            Application.Exit();  // Closes all forms in the application, releases all threads, and exits the application
        }
    }
}
