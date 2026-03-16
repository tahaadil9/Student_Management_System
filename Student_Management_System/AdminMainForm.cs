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
    public partial class AdminMainForm : Form
    {
       
        
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void ManageStudent_Button_Click(object sender, EventArgs e)
        {
            //Admin_Registration admin = new Admin_Registration();
            //admin.Show();
            //this.Hide();
            Register_Form register_Form = new Register_Form();
            register_Form.Show();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Admin_Login login = new Admin_Login();
            login.Show();
            this.Hide();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateReport_Form generateReport_Form = new GenerateReport_Form();
            generateReport_Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkAttendance attendance = new MarkAttendance();
            attendance.Show();
            this.Hide();

        }
    }
}
