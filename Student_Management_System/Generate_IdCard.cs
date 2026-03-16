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
    public partial class Generate_IdCard : Form
    {

        private Generate_IDCardClass IDCARD;

        public Generate_IdCard(Student student)
        {
            InitializeComponent();
            IDCARD = new Generate_IDCardClass(student);
            string name = IDCARD.SaveStdName();
            label9.Text = name;

            // Add more labels or controls to display other information
        }

        private void Generate_IdCard_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
