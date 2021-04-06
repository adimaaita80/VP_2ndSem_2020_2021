using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_Lesson1
{
    public class StudentsTable
    {
        public List<Student> Students { set; get; }

        public StudentsTable()
        {
            Students = new List<Student>();
        }
    }
}
