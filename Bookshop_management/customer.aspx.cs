using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookshop_management
{
    public partial class customer : System.Web.UI.Page
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
            string query = @"SELECT [c_id]
      ,[c_name]
      ,[c_email]
      ,[c_phone]
      ,[addr]
  FROM [dbo].[customer]";
            GridView1.DataSource = db.GetData(query);
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblcid = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            string query = @"DELETE FROM[dbo].[customer]
             WHERE c_id=" + lblcid.Text;
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

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex =-1;
            LoadGrid();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
                GridView1.EditIndex = e.NewEditIndex;
                 LoadGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblcid = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            TextBox txtcustomerid = (TextBox)GridView1.Rows[e.RowIndex].FindControl("customerID");
            TextBox txtcustomername = (TextBox)GridView1.Rows[e.RowIndex].FindControl("customerName");
            TextBox txtcustomermail = (TextBox)GridView1.Rows[e.RowIndex].FindControl("customerMail");
            TextBox txtcustomerphone = (TextBox)GridView1.Rows[e.RowIndex].FindControl("customerPhone");
            string query = @"UPDATE [dbo].[customer] SET [c_id] ='" + txtcustomerid.Text + "',[c_name] ='" + txtcustomername.Text + "',[c_email] ='" + txtcustomermail.Text + "',[phone] ='" + txtcustomerphone.Text + "' WHERE  c_id =" + txtcustomerid.Text;
            if (db.ExecuteQuery(query) == 1)
            {
                GridView1.EditIndex = -1;
                LoadGrid();
            }

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
    }
}