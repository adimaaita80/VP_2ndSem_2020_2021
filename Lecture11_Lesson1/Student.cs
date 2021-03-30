using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_Lesson1
{
    public class Student
    {
        public int StudentId { get; set; }

        /* Student Photo */
        public string StudentPhoto { get; set; }

        /* Personal Information */
        public string StudentFirstName { get; set; }
        public string StudentSecondName { get; set; }
        public string StudentThirdName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentCountryOfBirth { get; set; }
        public string StudentCityOfBirth { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public string StudentGender { get; set; }
        public string StudentNationality { get; set; }

        /* Contact Information */
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public string StudentMobile { get; set; }

        /* Address */
        public string StudentCountryOfResidence { get; set; }
        public string StudentCityOfResidence { get; set; }
        public string StudentStreet { get; set; }
        public string StudentBuilding { get; set; }

        /* Education */
        public string StudentDegree { get; set; }
        public string StudentSchool { get; set; }
        public DateTime StudentGraduationDate { get; set; }
        public double StudentGPA { get; set; }
    }
}
