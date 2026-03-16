using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Student_Management_System
{
    public class Student
    {
        public string _Password, _ConfirmPassword, _FullName, _Email, _Contact, _Address, Gender, _Username;

        public Student(string password, string confirmPassword, string fullName, string email, string contact, string address, string gender, string userName)
        {
            _Password = password;
            _ConfirmPassword = confirmPassword;
            _FullName = fullName;
            _Email = email;
            _Contact = contact;
            _Address = address;
            Gender = gender;
            _Username = userName;

            
        }

        public bool CheckEmptyFieldsandPassword(ErrorProvider errorProvider, Control confirmControl)
        {
            if (string.IsNullOrEmpty(_FullName) || string.IsNullOrEmpty(_Email) ||
                string.IsNullOrEmpty(_Contact) || string.IsNullOrEmpty(_Address) ||
                string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(_Username) || string.IsNullOrEmpty(_Password))
            {
                MessageBox.Show("Some Fields are missing, Please Fill out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (_Password != _ConfirmPassword)
            {
                errorProvider.SetError(confirmControl, "Password and Confirm Password Doesn't Match");
                return false;
            }
            else
            {
                MessageBox.Show("Submitted Successfully, \n You can now Register Courses", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }


        }
    }
}




