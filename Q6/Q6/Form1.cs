using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string gender = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            string status = textBox3.Text;
            string Insured = "";

            if(status == "married")
            {
                Insured = "You are Insured";
            }
            if(status == "unmarried" && gender == "male" && age > 30)
            {
                Insured = "You are Insured";
            }
            if(status == "unmarried" && gender == "female" && age > 24)
            {
                Insured = "You are Insured";
            }
            else
            {
                Insured = "You are not Insured";
            }
            textBox4.Text = Insured;
        }
    }
}
