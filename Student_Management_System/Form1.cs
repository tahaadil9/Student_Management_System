using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            Register_Form objregister = new Register_Form();
            objregister.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Std_Username = Username_TextBox.Text;
            string Std_Password = Password_TextBox.Text;

            
            Student_LoginClass loginclass = new Student_LoginClass();
            if(loginclass.CheckEmptyFieldsAndPassword(Username_TextBox.Text, Password_TextBox.Text))
            {
                StudentMainForm form = new StudentMainForm();
                form.Show();
                this.Hide();
            }

           
           
        }

        private void LoginAdmin_Button_Click(object sender, EventArgs e)
        {
            Admin_Login admin = new Admin_Login();
            admin.Show();

            this.Hide();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
