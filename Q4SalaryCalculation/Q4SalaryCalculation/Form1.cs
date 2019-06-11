using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4SalaryCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string gender = textBox1.Text;
            string Qualification = textBox2.Text;
            int yearOfService = Convert.ToInt32(textBox3.Text);
            int Salary = 0;

               if(gender == "Male")
            {
                if((Qualification == "MS" || Qualification == "MBA") && yearOfService >= 5)
                {
                    Salary = 90000;
                }
                else if ((Qualification == "BS" || Qualification == "MCS") && yearOfService >= 5)
                {
                    Salary = 60000;
                }
                else if ((Qualification == "BS" || Qualification == "MCS") && yearOfService < 5)
                {
                    Salary = 50000;
                }
                else if (Qualification == "BBA" && yearOfService < 5)
                {
                    Salary = 25000;
                }
            }
            else if(gender == "Female")
            {
                if ((Qualification == "MS" || Qualification == "MBA") && yearOfService >= 5)
                {
                    Salary = 80000;
                }
                else if ((Qualification == "BS" || Qualification == "MCS") && yearOfService >= 5)
                {
                    Salary = 55000;
                }
                else if ((Qualification == "BS" || Qualification == "MCS") && yearOfService < 5)
                {
                    Salary = 40000;
                }
                else if (Qualification == "BBA" && yearOfService < 5)
                {
                    Salary = 20000;
                }
            }
            textBox4.Text = Convert.ToString(Salary);
        }
    }
}
