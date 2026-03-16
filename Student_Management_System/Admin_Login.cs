using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Student_Management_System
{
    public partial class Admin_Login : Form
    {
        //OleDbConnection con_Admin_Login=new OleDbConnection();

        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Button_Click(object sender, EventArgs e)
        {
            string EnteredUsername = AdminUserName_TextBox.Text;
            string EnteredPassword = AdminPassword_TextBox.Text;

            AdminLoginClass adminLogin = new AdminLoginClass("Admin", "123");

            if (adminLogin.CheckAuthentication(EnteredUsername, EnteredPassword))
            {
                AdminMainForm mainform = new AdminMainForm();
                mainform.Show();
                this.Hide();
            }






            //string enteredValue = AdminUserName_TextBox.Text;

            //con_Admin_Login.Open();
            //OleDbCommand cmd = new OleDbCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into table values('" + AdminUserName_TextBox.Text + "','" + AdminPassword_TextBox.Text + "')";
            //cmd.ExecuteNonQuery();
            //con_Admin_Login.Close();
            //MessageBox.Show("Thanks For Login.");
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Form1 studentlog = new Form1();
            studentlog.Show();

            this.Hide();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminPassword_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
