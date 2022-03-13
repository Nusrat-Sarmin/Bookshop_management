using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Bookshop_management
{
    public class Class1
          
    {
        string connectstr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public DataTable GetData(string query)
        {
            SqlConnection conn = new SqlConnection(connectstr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
           
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ExecuteQuery(string query)
        {

            SqlConnection conn = new SqlConnection(connectstr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
            }

        }
    }

}