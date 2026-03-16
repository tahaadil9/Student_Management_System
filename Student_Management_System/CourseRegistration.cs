using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class CourseRegistration : Form
    {
        private readonly Course currentCourse;
        private string selectedCourse;
        private string selectedTime;

        public CourseRegistration(Student student)
        {
            InitializeComponent();

            comboBox1.Items.Add("Programming");
            comboBox1.Items.Add("DataBase");
            comboBox1.Items.Add("Automata");

            comboBox2.Items.Add("8:40:00 AM - 11:30:00 AM");
            comboBox2.Items.Add("12:30:00 PM - 3:30:00 PM");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            currentCourse = new Course(student);
            label8.Text = student._FullName;
            label9.Text = student._Email;
            label10.Text = student._Contact;

            
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCourse) || !string.IsNullOrEmpty(selectedTime))
            {
                currentCourse.SaveCourse(selectedCourse, selectedTime);
                label11.Text = selectedCourse;
                label13.Text = selectedTime;
               

            }

            

            else
            {
                MessageBox.Show("Please select a course.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedCourse = comboBox.SelectedItem.ToString();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            selectedTime = combobox.SelectedItem.ToString();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Register_Form register_Form = new Register_Form();
            register_Form.Show();
            this.Hide();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
