using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Course
    {
        private Student student;
        private FileManager fileManager;
        string SelectedCourse;
        public Course()
        {

        }
        public Course(Student student, string fileName = "course_data.txt")
        {
            this.student = student;
            this.fileManager = new FileManager(fileName);
        }

         public void SaveCourse(string selectedCourse, string selectedTime)
         {
            this.SelectedCourse = selectedCourse;

            string dataToSave = $"Name: {student._FullName} \n Email: {student._Email} \n Contact: {student._Contact} \n Address: {student._Address} \n Username: {student._Username} Course: {selectedCourse} -- {selectedTime}";
           
            fileManager.SaveToFile(dataToSave);
         }

    }
}
