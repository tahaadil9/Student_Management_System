using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public class Student_LoginClass
    {
        public Student_LoginClass() 
        {
        
        }

        public virtual bool CheckEmptyFieldsAndPassword(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {

                MessageBox.Show("Please enter Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            else
            {
                return true;
            }

            
        }
    }
}
