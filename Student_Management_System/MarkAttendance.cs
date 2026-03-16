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
    public partial class MarkAttendance : Form
    {
        public MarkAttendance()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            AttendanceStatus attendanceStatus;

            if (radioButton1.Checked)
            {
                attendanceStatus = new PresentAttendanceStatus();
            }
            else if (radioButton6.Checked)
            {
                attendanceStatus = new AbsentAttendanceStatus();
            }

            else
            {
                MessageBox.Show("Please select attendance status.");
                return;
            }

            Attendence attendenceForm = new Attendence();
            attendanceStatus.SetLabel(attendenceForm);
            attendenceForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMainForm mainForm = new AdminMainForm();   
            mainForm.ShowDialog();
            this.Hide();

        }
    }
}
