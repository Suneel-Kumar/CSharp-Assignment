using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowData();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5EHPR00\\SQLEXPRESS;Initial Catalog=SimpleDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO UserInfo (Name, Contact, Age, Email, Location, Date) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + Convert.ToInt32(textBox3.Text) + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text + "', '" + (Convert.ToDateTime(textBox6.Text)) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ShowData();
            MessageBox.Show("Data Inseted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowData()
        {
            adpt = new SqlDataAdapter("SELECT * FROM UserInfo", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM UserInfo Where Name = '" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE UserInfo SET (Contact = '" + textBox2.Text + "', Age ='" + Convert.ToInt32(textBox3.Text) + "', Email = '" + textBox4.Text + "', Location = '" + textBox5.Text + "', Date = '" + textBox6.Text.ToString() + "') WHERE Name = '"+textBox1.Text.ToString()+"';", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FORM UserInfo Where Like Name = '"+textBox7.Text+" % ' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ShowData();
        }
    }
}
