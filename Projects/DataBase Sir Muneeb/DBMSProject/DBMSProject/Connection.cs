using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBMSProject
{
    class Connection
    {
        public static SqlConnection con;

        public static SqlConnection GetConnection()
        {
            if(con == null)
            {
                con = new SqlConnection("Data Source=DESKTOP-5EHPR00\\SQLEXPRESS;Initial Catalog=HMA;Integrated Security=True");
            }
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}