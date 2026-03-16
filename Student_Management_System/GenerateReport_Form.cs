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
    public partial class GenerateReport_Form : Form
    {
        public GenerateReport_Form()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
             //print button
            int SessionalMarks = int.Parse(Sessional_Marks_textbox.Text);
            int MidTermMarks = int.Parse(MidTerm_Marks_textbox.Text);
            int FinalMarks = int.Parse(Finalterm_Marks_textbox.Text);
            int FinalProjectMarks = int.Parse(FinalProject_Marks_textbox.Text);

            GenerateReportClass StudentReport = new GenerateReportClass(SessionalMarks,MidTermMarks,FinalMarks,FinalProjectMarks);
            int Total = StudentReport.Calculate_TotalMarks();

            label11.Text = Total.ToString();
            label11.Show();

            string Status = StudentReport.Calculate_Status(Total);
            label12.Text = Status.ToString();
            label12.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            AdminMainForm mainform = new AdminMainForm();
            mainform.Show();
            this.Hide();
        }

        private void Finalterm_Marks_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinalProject_Marks_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
