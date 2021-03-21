using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7_Lesson1
{
    public class Baby
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string BabyInformation()
        {
            return $"Baby's Name: {FirstName} {MiddleName} {LastName}";
        }
    }
}
