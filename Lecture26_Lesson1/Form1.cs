using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lecture26_Lesson1
{
    public partial class Form1 : Form
    {
        private static string formState = "Add";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            formState = "Add";
            txtName.Text = "";
            txtEmployeeId.Text = "";
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(formState == "Add")
            {
                SqlCommand command = new SqlCommand($"insert into Employees values('{txtName.Text}')", DB_Common.connection);

                DB_Common.OpenConnection();
                command.ExecuteNonQuery();
                DB_Common.CloseConnection();

                RefreshDataGridView();
            }
            else if(formState == "Update")
            {
                SqlCommand command = new SqlCommand($"update Employees Set EmployeeName = '{txtName.Text}' where EmployeeId = {txtEmployeeId.Text}", DB_Common.connection);

                DB_Common.OpenConnection();
                command.ExecuteNonQuery();
                DB_Common.CloseConnection();

                RefreshDataGridView();

                formState = "Add";
                txtName.Text = "";
                txtEmployeeId.Text = "";
                txtName.Focus();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Delete from Employees where EmployeeId = {txtEmployeeId.Text}", DB_Common.connection);

            DB_Common.OpenConnection();
            command.ExecuteNonQuery();
            DB_Common.CloseConnection();

            RefreshDataGridView();

            formState = "Add";
            txtName.Text = "";
            txtEmployeeId.Text = "";
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formState = "Add";
            txtName.Text = "";
            txtEmployeeId.Text = "";
            txtName.Focus();
        }

        private void RefreshDataGridView()
        {
            SqlCommand command = new SqlCommand("Select * from Employees", DB_Common.connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataTable employeesTable = new DataTable();

            sqlDataAdapter.Fill(employeesTable);

            dataGridView1.DataSource = employeesTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            formState = "Update";
        }

        
    }
}
