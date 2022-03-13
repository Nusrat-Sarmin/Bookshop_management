using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Bookshop_management
{
    public partial class login : System.Web.UI.Page
    {
       
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        
       // Class1 db = new Class1();
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectstr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from admin where u_name='" + TextBox1.Text + "' and pass ='" + TextBox3.Text + "' ",conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Response.Write("alert('successful in login')"); //write Script tag before writing alert and close script tag as shown in below
                    Response.Redirect("~/admin.aspx");
                }
                else
                {
                    Label1.Text = "Data is not found";
                }
            }
            catch(Exception ex)
             {
                Response.Write(ex.Message);
            }
            // string query = @"SELECT * FROM [dbo].[admin] WHERE u_name='"+TextBox1.Text+"and email'"+TextBox2.Text+ "'and pass'" + TextBox3.Text + "'";
            // if (ds.Tables[0].Rows.Count > 0)

            //if (db.ExecuteQuery(query)==1 )
            // {
            // Response.Redirect("buybook.aspx");

            //}

            // else
            // {
            //Label1.Text = "Data is not found";

            //  }

        }
    }
}