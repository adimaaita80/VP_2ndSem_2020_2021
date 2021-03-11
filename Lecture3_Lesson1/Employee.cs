using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Lesson1
{
    public class Employee
    {
        // In C# we use properties instead of plain attributes
        // e.g. Attribute
        //private int employeeName;

        // Now use properties
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public Employee()
        {

        }

        public Employee(int empId, string empName)
        {
            EmployeeId = empId;
            EmployeeName = empName;
        }

        // Now let us implement some functionality
        public string EmployeeInformation()
        {
            return $"Employee ID: {EmployeeId}, Employee Name: {EmployeeName}";
        }

    }
}
