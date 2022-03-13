using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookshop_management
{
    public partial class admin : System.Web.UI.Page
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
            string query = @"INSERT INTO [dbo].[book]
           ([book_name]
           ,[writer_name]
           ,[price])
     VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "') ";
            if (db.ExecuteQuery(query) == 1)
            {
                LoadGrid();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblbookid = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            string query = @"DELETE FROM[dbo].[book]
             WHERE book_no=" + lblbookid.Text;
            if (db.ExecuteQuery(query) == 1)
            {
                LoadGrid();
            }
        }

       
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadGrid();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGrid();
        }

       

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadGrid();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblbookid = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            TextBox txtbookid = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
            TextBox txtbookName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox txtwriter = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox txtprice = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");
           
            string query = @"UPDATE [dbo].[book]
            SET[book_no] ='" + txtbookid.Text + "',[book_name] ='" + txtbookName.Text + "',[writer_name] ='" + txtwriter.Text + "',[price] ='" + txtprice.Text + "' WHERE  book_no =" + txtbookid.Text;
            if (db.ExecuteQuery(query) == 1)
            {
                GridView1.EditIndex = -1;
                LoadGrid();
            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/customer.aspx");
        }
    }
}