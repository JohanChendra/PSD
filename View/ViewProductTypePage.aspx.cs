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
    public partial class ViewProductTypePage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                RefreshGridView();
            }
        }

        private void RefreshGridView()
        {
            ProductTypeGridView.DataSource = ProductTypesRepository.GetProductTypes();
            ProductTypeGridView.DataBind();
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void InsertProductTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductTypePage.aspx");
        }

        protected void ProductTypeGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowindex = e.RowIndex;
            string ProductTypeid = ProductTypeGridView.Rows[rowindex].Cells[2].Text;
            Response.Redirect("UpdateProductTypePage.aspx?ID=" + ProductTypeid);
        }

        protected void ProductTypeGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowindex = e.RowIndex;
            int ProductTypeid = Int32.Parse(ProductTypeGridView.Rows[rowindex].Cells[2].Text);
            ProductTypesRepository.DeleteProductType(ProductTypeid);
            RefreshGridView();
        }
    }
}