using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookshop_management
{
    public partial class bookinfo : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }
        public void LoadGrid()
        {
            string query = @"SELECT [book_no]
                              ,[book_name]
                              ,[writer_name]
                              ,[price]
                          FROM [dbo].[book]
                        ";
            GridView1.DataSource = db.GetData(query);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("buybook.aspx");
        }
    }
}