using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class DBHandler
    {
        string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        

        public int InsertInfo(Info info)
        {
            SqlConnection sql = new SqlConnection(con);
            sql.Open();

            SqlCommand cmd = new SqlCommand("PROCEDURE", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", info.Name);
            cmd.Parameters.AddWithValue("@Desc", info.Description);
            cmd.Parameters.AddWithValue("@Type", info.Type);
            int rows = cmd.ExecuteNonQuery();
            sql.Close();
            return rows;
        }
    }
}