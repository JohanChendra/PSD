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
    public partial class UpdateProductTypePage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Request.QueryString["ID"]);
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Request.QueryString["ID"]);
            string name = ProductTypetxt.Text;
            string description = desctxt.Text;

            if (name == "")
            {
                Labelerror.Text = "Product Type kosong";
            }
            else if (description == "")
            {
                Labelerror.Text = "Description Kosong";
            }
            else
            {
                ProductTypesRepository.UpdateProductType(ID, name, description);
                Response.Redirect("ViewProductTypePage.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductTypePage.aspx");
        }
    }
}