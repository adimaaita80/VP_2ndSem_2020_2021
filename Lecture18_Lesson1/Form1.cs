using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture18_Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button myButton = new Button();
            myButton.Name = "btnGeneratedButton";
            myButton.Text = "My Generated Button";
            myButton.Width = 120;
            myButton.Height = 40;
            myButton.Location = new Point(200, 200);
            myButton.Click += new EventHandler(myButton_Click);

            this.Controls.Add(myButton);


            TextBox myTextBox = new TextBox();
            myTextBox.Name = "myTextBox";
            myTextBox.Width = 200;
            myTextBox.Height = 40;
            myTextBox.Location = new Point(500, 500);
            myTextBox.TextChanged += new EventHandler(myTextBox_TextChanged);

            this.Controls.Add(myTextBox);
        }


        private void myButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The generated button was clicked.");
        }

        private void myTextBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You changed the text inside.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("This form has been closed by the user.");
        }
    }
}
