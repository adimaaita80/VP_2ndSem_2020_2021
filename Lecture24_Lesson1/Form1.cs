using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture24_Lesson1
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vP_Lect24DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.vP_Lect24DataSet.Employees);

        }
    }
}
