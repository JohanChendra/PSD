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
    public partial class UpdateProductPage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Request.QueryString["ID"]);
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Request.QueryString["ID"]);
            string name = Nametxt.Text;
            if (name == "")
            {
                Labelerror.Text = "Name kosong";
            }
            else if (Stocktxt.Text == "")
            {
                Labelerror.Text = "Stock kosong";
            }
            else if (Pricetxt.Text == "")
            {
                Labelerror.Text = "Price kosong";
            }
            else
            {
                int stock = Int32.Parse(Stocktxt.Text.ToString());
                int price = Int32.Parse(Pricetxt.Text.ToString());
                if (price < 1000)
                {
                    Labelerror.Text = "Price dibawah minimum price";
                }
                else if ((price % 1000) != 0)
                {
                    Labelerror.Text = "Price tidak kelipatan 1000";
                }
                else
                {
                    ProductRepository.UpdateProduct(ID, name, stock, price);
                    Response.Redirect("ViewProductPage.aspx");
                }
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductPage.aspx");
        }
    }
}