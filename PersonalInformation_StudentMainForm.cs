using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class PersonalInformation_StudentMainForm : Form
    {
        public PersonalInformation_StudentMainForm()
        {


            InitializeComponent();
          
        }

       

        private void Back_Button_Click(object sender, EventArgs e)
        {
            StudentMainForm studentMainForm = new StudentMainForm();
            studentMainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1 == null)
            {
                MessageBox.Show("Please Send Request");
            }
            else
            {
                MessageBox.Show("Your Request has been sent!");
            }
        }
    }
}
