using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public class AdminLoginClass
    {
        private string savedUsername;                //private properties
        private string savedPassword;
        public AdminLoginClass(string username , string password)
        {
            this.savedUsername = username;
            this.savedPassword = password;
        }

        public bool CheckAuthentication(string EnteredUsername, string EnteredPassword)
        {
            
            if (string.IsNullOrWhiteSpace(EnteredUsername))
            {

                MessageBox.Show("Please enter Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
               
            }

            else if (string.IsNullOrWhiteSpace(EnteredPassword))
            {
                MessageBox.Show("Please enter Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            else if(savedUsername != EnteredUsername && savedPassword != EnteredPassword)
            {
                MessageBox.Show("Username Or Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {

                return true;
               
            }
        }
    }
}
