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
    public partial class StudentMainForm : Form
    {
        Student student;
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void ManageStudent_Button_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalInformation_StudentMainForm personalInformation = new PersonalInformation_StudentMainForm();
           personalInformation.Show();
            this.Hide();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void ID_Card_Click(object sender, EventArgs e)
        {

            if (student != null)
            {
                Generate_IdCard generate_IdCard = new Generate_IdCard(student);
                generate_IdCard.Show();
            }
            else
            {
                MessageBox.Show("Please fill out the registration form first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Test result

        }
    }
}
