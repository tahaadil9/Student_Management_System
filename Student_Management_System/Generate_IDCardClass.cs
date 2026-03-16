using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
     public class Generate_IDCardClass : Course
     {
        Student Student { get; set; }
        string fileName { get; set; }

        // Constructor
        public Generate_IDCardClass(Student student, string fileName = "course_data.txt") : base(student, fileName)
        {
            this.Student = student;
        }

        public string SaveStdName()
        {
            string Name = Student._FullName;
            return Name;
        }
        public string SaveStdEmail()
        {
            string Email = Student._Email;
            return Email;

        }





    }
}
