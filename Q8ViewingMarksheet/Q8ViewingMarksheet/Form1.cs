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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int eng = Convert.ToInt32(textBox1.Text);
            int math = Convert.ToInt32(textBox1.Text);
            int phy = Convert.ToInt32(textBox1.Text);
            int che = Convert.ToInt32(textBox1.Text);
            int urdu = Convert.ToInt32(textBox1.Text);
            int isl = Convert.ToInt32(textBox1.Text);

            Form2 innerForm = new Form2();
            innerForm.FormClosing += (a, b) => this.Close();
            innerForm.Show();
            this.Hide();
        }
    }
}
