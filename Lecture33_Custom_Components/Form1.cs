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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> employeesList = new List<Employee>();

            Employee employee1 = new Employee("Adi", "adi@adi.com", "1234");
            Employee employee2 = new Employee("Ahmad", "ahmad@ahmad.com", "1234");
            Employee employee3 = new Employee("Khaled", "khaled@kahled.com", "1234");
            Employee employee4 = new Employee("Samer", "samer@samer.com", "1234");
            Employee employee5 = new Employee("Rami", "rami@rami.com", "1234");
            Employee employee6 = new Employee("Mahmoud", "mahmoud@mahmoud.com", "1234");

            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);
            employeesList.Add(employee6);

            foreach (Employee emp in employeesList)
            {
                EmployeeCard employeeCard = new EmployeeCard();
                employeeCard.EmployeeName = emp.EmployeeName;
                employeeCard.EmployeeEmail = emp.EmployeeEmail;
                employeeCard.EmployeePhone = emp.EmployeePhone;

                flowLayoutPanel1.Controls.Add(employeeCard);
            }


        }
    }
}
