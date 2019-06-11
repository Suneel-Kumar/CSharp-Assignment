using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_ChaseUpStore
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

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int item1Price = Convert.ToInt32(textBox1.Text);
            int item2Price = Convert.ToInt32(textBox4.Text);
            int item3Price = Convert.ToInt32(textBox6.Text);
            int item4Price = Convert.ToInt32(textBox8.Text);

            int item1Quan = Convert.ToInt32(textBox2.Text);
            int item2Quan = Convert.ToInt32(textBox3.Text);
            int item3Quan = Convert.ToInt32(textBox5.Text);
            int item4Quan = Convert.ToInt32(textBox7.Text);

            int total = (item1Price * item1Quan) + (item2Price * item2Quan) + (item3Price * item3Quan) + (item4Price * item4Quan);
            if(total > 5000)
            {
                total = total - (total * 10 / 100);
            }
            textBox9.Text = Convert.ToString(total);
        }
    }
}
