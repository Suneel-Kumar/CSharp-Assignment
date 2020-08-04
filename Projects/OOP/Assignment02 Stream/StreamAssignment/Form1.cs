using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamAssignment
{
    public partial class Form1 : Form
    {
        //Contact cont;
        public Form1()
        {
            InitializeComponent();
            //cont = new Contact();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (StreamWriter sw = new StreamWriter("File.txt", true))
            {
                
                    string UserName = textBox1.Text;
                    string ContactNo = textBox2.Text;
                //if (UserName != "" && ContactNo != "")
                //{
                //    string UserData = UserName + " =>  " + ContactNo;
                //    sw.WriteLine(UserData);
                //}
                //else
                //{
                //    MessageBox.Show("Please Fill The given Field", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //}

                    textBox1.Clear();
                    textBox1.Focus();
                    textBox2.Clear();                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("File.txt", true))
            {
                while (!(sr.EndOfStream))
                {
                    //listBox1.Items.Contains(sr.ReadLine()); 
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String search = "";
            search = textBox3.Text;
            for(int i=listBox1.Items.Count-1; i > 0; i--)
            {
                if(listBox1.Items[i].ToString().Contains(textBox3.Text))
                {
                    listBox1.SetSelected(i, true);
                    //MessageBox.Show("Yes Found");
                }
            }
        }
    }
}
