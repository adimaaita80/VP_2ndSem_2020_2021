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
    public partial class frmLab3 : Form
    {
        public frmLab3()
        {
            InitializeComponent();
        }

        private void btnMoveForm_Click(object sender, EventArgs e)
        {
            int xValue = int.Parse(txtX.Text);
            int yValue = int.Parse(txtY.Text);

            this.Location = new Point(xValue, yValue);
        }
    }
}
