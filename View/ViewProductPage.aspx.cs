using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class ViewProductPage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                InsertProductButton.Visible = false;
                ProductsGridView.Columns[0].Visible = false;
                ProductsGridView.Columns[1].Visible = false;
            }
            else
            {
                int ID = Int32.Parse(Session["ID"].ToString());
                User u = UserRepository.GetUserid(ID);
                if(u.RoleID == 1)
                {
                    InsertProductButton.Visible = false;
                    ProductsGridView.Columns[0].Visible = false;
                    ProductsGridView.Columns[1].Visible = false;
                }
            }
            RefreshGridView();
        }
        private void RefreshGridView()
        {
            ProductsGridView.DataSource = ProductRepository.GetProducts();
            ProductsGridView.DataBind();
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void InsertProductButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductPage.aspx");
        }

        protected void ProductsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowindex = e.RowIndex;
            int Productid = Int32.Parse(ProductsGridView.Rows[rowindex].Cells[2].Text);
            ProductRepository.DeleteProduct(Productid);
            RefreshGridView();
        }

        protected void ProductsGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowindex = e.RowIndex;
            string Productid = ProductsGridView.Rows[rowindex].Cells[2].Text;
            Response.Redirect("UpdateProductPage.aspx?ID=" + Productid);
        }
    }
}