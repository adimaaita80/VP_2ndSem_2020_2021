using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture22_MidtermExamRevision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.Controls.Add(new Button() { Name = "btnNew", Text = "btnNew", Width = 80, Height = 50 });

            listBox1.Items.Add("Hello");

        }
    }
}
