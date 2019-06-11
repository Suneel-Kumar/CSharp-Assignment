using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q8ViewingMarksheet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Suneel Kumar";
            textBox2.Text = "Jhaman Das";
            textBox3.Text = "Govt High School No: II Umerkot";
            textBox4.Text = "Malhi";
            textBox5.Text = "34055";

            int eng = Convert.ToInt32(textBox6.Text);
            int math = Convert.ToInt32(textBox7.Text);
            int phy = Convert.ToInt32(textBox8.Text);
            int che = Convert.ToInt32(textBox9.Text);
            int urdu = Convert.ToInt32(textBox10.Text);
            int isl = Convert.ToInt32(textBox11.Text);

            int TotalMarks = 600;
            textBox12.Text = Convert.ToString(TotalMarks);
            int total = eng + math + phy + che + urdu + isl;
            textBox13.Text = Convert.ToString(total);

            int per = (total * 100) / 600;
            textBox15.Text = Convert.ToString(per + "%");

            string Grade = "";
            if(per > 90)
            {
                Grade = "A+";
            } 
            else if(per > 80)
            {
                Grade = "A";
            }
            else if(per > 70)
            {
                Grade = "B";
            }
            else if(per > 60)
            {
                Grade = "C";
            }
            else
            {
                Grade = "Fail";
            }
            textBox14.Text = Grade;
        }
    }
}
