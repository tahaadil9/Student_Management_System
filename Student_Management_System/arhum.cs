using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public class arhum
    {
        public void get_info(string f_name, string l_name, string ph, string E_mail, string username, string passcode, string gender_m, string gender_f, bool gender, string check_password)
        {
            if (string.IsNullOrWhiteSpace(f_name) || string.IsNullOrEmpty(l_name) || string.IsNullOrWhiteSpace(ph) || string.IsNullOrWhiteSpace(E_mail) || string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(passcode) || string.IsNullOrEmpty(check_password))
            {
                MessageBox.Show("Some Field are missing, Please Fill out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (passcode == check_password)
            {
               
                MessageBox.Show("Saved Successfully! \n You can now login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string FirstName = f_name;
                string LastName = l_name;
                string Email = E_mail;
                string Contact = ph;
               
            }

            else
            {
                MessageBox.Show("Password and Confirm Password Doesn't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string Gender;
                if (gender != true)
                {
                    Gender = gender_m;
                }

                else
                {
                    Gender = gender_f;
                }

                string UserName = username;
                string Password = passcode;
            }
        }
    }
}
