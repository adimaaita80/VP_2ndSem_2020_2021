using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Our lesson today is about classes and objects

            // Let's create an object of type Employee
            //Employee employee = new Employee();

            //employee.EmployeeId = 1;
            //employee.EmployeeName = "Adi Maaita";

            //Console.WriteLine($"Employee ID: {employee.EmployeeId}, Employee Name: {employee.EmployeeName}");


            Employee employee = new Employee(1, "Adi Maaita");

            string summary = employee.EmployeeInformation() + "********";

            Console.WriteLine(summary);

            //Console.WriteLine(employee.EmployeeInformation());

        }
    }
}
