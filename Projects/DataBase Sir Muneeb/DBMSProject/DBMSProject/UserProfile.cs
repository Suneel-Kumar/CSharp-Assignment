using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DBMSProject
{
    class UserProfile
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }
        public Decimal Weight { get; set; }
        public Decimal Height { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }

        public UserProfile() { }

        public UserProfile(string name, string email, int age, string contact, Decimal weight, Decimal height, string username, string pass)
        {
            Name = name; Email = email; Age = age; Contact = contact; Weight = weight; Height = height; Username = username; Pass = pass;
        }

        public void SaveData()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Userinfo VALUES('"+Name+"', '"+Email+"', "+Age+", '"+Contact+"', "+Weight+", "+Height+", '"+Username+"', '"+Pass+"')", Connection.GetConnection());
            cmd.ExecuteNonQuery();
        }

        internal void ClearData(TextBox Name, TextBox Email, TextBox Age, TextBox Contact, TextBox Weight, TextBox Height, TextBox Username, TextBox Pass)
        {
            Name.Clear(); Email.Clear(); Age.Clear(); Contact.Clear(); Weight.Clear(); Height.Clear(); Username.Clear(); Pass.Clear();
        }

        public bool Login(string Name, string Pass)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Userinfo WHERE Username = '" + Name + "' AND Password = '"+Pass+"';", Connection.GetConnection());
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable ShowData()
        {
            SqlCommand cmd = new SqlCommand("GetAllProfiles", Connection.GetConnection());
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
    }
}