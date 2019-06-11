using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5AgeYoungestPeople
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int alphaAge = Convert.ToInt32(textBox1.Text);
            int bravoAge = Convert.ToInt32(textBox2.Text);
            int charlieAge = Convert.ToInt32(textBox3.Text);

            string youngerName = "";
            int younger = alphaAge;
            if (bravoAge > younger)
            {
                youngerName = "Bravo";
            }
            else if(charlieAge > younger)
            {
                youngerName = "charlie";
            }
            else
            {
                youngerName = "Alpha";
            }
            textBox4.Text = youngerName;
        }
    }
}
