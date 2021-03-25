using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9_Lesson1
{
    public partial class frmLab2 : Form
    {
        public frmLab2()
        {
            InitializeComponent();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            MessageBox.Show($"The new color is: {this.BackColor}");
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            MessageBox.Show($"The new color is: {this.BackColor}");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            MessageBox.Show($"The new color is: {this.BackColor}");
        }
    }
}
