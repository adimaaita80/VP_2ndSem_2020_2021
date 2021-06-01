using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture33_Custom_Components
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }

        public Employee(string employeeName, string employeeEmail, string employeePhone)
        {
            EmployeeName = employeeName;
            EmployeeEmail = employeeEmail;
            EmployeePhone = employeePhone;
        }
    }
}
