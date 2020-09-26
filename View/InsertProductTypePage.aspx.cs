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
    public partial class InsertProductTypePage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = ProductTypetxt.Text;
            string description = Desctxt.Text;

            if (name =="")
            {
                Labelerror.Text = "Product type salah";
            }
            else if (description =="")
            {
                Labelerror.Text = "Description kosong";
            }
            else
            {
                ProductTypesRepository.InsertProductType(name, description);
                Response.Redirect("ViewProductTypePage.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductTypePage.aspx");
        }
    }
}