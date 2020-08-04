using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form2 : Form
    {
        public Form2(string getValue, string userName, string password)
        {
            InitializeComponent();
            label1.Text = getValue;
            label2.Text = userName;
            label3.Text = password;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
