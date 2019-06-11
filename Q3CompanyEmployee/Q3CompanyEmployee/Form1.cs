using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3CompanyEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int MonthlyIncome = Convert.ToInt32(textBox1.Text);
            int Allowance;
            int homeAllowance;
            int grossIncome = 0;
            int diningAllowance;
            if(MonthlyIncome < 18000)
            {
                 homeAllowance = (MonthlyIncome * 12 )/ 100;
                 Allowance = (MonthlyIncome * 90 / 100);
                 grossIncome = MonthlyIncome + Allowance;
            }
            if(MonthlyIncome<22000 && MonthlyIncome >= 1700)
            {
                 homeAllowance = 700;
                 diningAllowance = MonthlyIncome * 96 / 100;
                 grossIncome = MonthlyIncome + diningAllowance;
            }
            textBox2.Text = Convert.ToString(grossIncome);
            
        }
    }
}
