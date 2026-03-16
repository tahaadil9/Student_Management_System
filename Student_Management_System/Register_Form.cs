using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Register_Form : Form
    {
        private Student student;
        PersonalInformation_StudentMainForm personalInformation_;

        public Register_Form()
        {
            InitializeComponent();
            CourseRegister_Button.Enabled = false;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string Gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;

            student = new Student(SetPassword_TextBox.Text, ConfirmPassword_TextBox.Text,
                                  FullName_TextBox.Text, Emailaddress_TextBox.Text,
                                  Contact_TextBox.Text, Address_RichBox.Text,
                                  Gender, SetUsername_TextBox.Text);

          

            if (student.CheckEmptyFieldsandPassword(errorProvider2, ConfirmPassword_TextBox))
            {
                CourseRegister_Button.Enabled = true;

               

            }

          


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Form1 studentlog = new Form1();
            studentlog.Show();
            this.Close();
        }

        private void CourseRegister_Button_Click(object sender, EventArgs e)
        {
            if (student != null)
            {
                CourseRegistration objCRegister = new CourseRegistration(student);
                objCRegister.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please fill out the registration form first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        
        
        private void Emailaddress_TextBox_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void ConfirmPassword_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
