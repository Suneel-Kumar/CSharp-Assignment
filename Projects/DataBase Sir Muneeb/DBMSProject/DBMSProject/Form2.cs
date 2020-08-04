using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfile user = new UserProfile(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), textBox7.Text, textBox8.Text);
            user.SaveData();
            MessageBox.Show("Data Saved Successfully");
            user.ClearData(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
