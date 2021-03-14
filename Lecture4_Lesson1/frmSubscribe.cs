using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture4_Lesson1
{
    public partial class frmSubscribe : Form
    {
        public frmSubscribe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the code inside this block will be executed.

            string myName = txtMyName.Text;
            string myEmail = txtMyEmail.Text;
            string messageToShow = $"Your Name: {myName} \n Your Email: {myEmail}";

            MessageBox.Show(messageToShow);
        }
    }
}
