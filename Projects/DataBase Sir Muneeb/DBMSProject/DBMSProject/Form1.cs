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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfile user = new UserProfile();
            if(user.Login(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                DataGrid Gd = new DataGrid();
                Gd.Show();
            }
            else
            {
                MessageBox.Show("Jaa Bay..... Username ya Password theek kr k aa pehle... CHAL NIKAALLLLLLL!!!!");
            }
        }
    }
}