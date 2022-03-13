using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookshop_management
{
    public partial class buybook : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query =@" INSERT INTO[dbo].[customer]
           ([c_name]
           ,[c_email]
           ,[c_phone]
           ,[addr])
     VALUES('"+ TextBox1.Text+ "','" + TextBox2.Text + "','" + TextBox3.Text + "','"+TextBox4.Text+"')";
          //  db.ExecuteQuery(query);
            if (db.ExecuteQuery(query) == 1)
            {
                Response.Write("<script>alert('info succesfully saved');</script>");
               // Response.Redirect("buybook.aspx");
            }
           
        }
    }
}