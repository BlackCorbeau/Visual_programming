using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using backend;

namespace var4_pr1
{
    public partial class Form1 : Form
    {
        data Working = new data();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string faculty;
            faculty = textBox1.Text;
            Working.Get_Data_faculty(faculty);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Deas_name;
            Deas_name = textBox2.Text;
            Working.Get_Data_Deas_name(Deas_name);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string Abbriviation;
            Abbriviation = textBox3.Text;
            Working.Get_Data_Abriviation(Abbriviation);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Working._Create_File();
        }
    }
}
