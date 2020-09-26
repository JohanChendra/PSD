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
    public partial class HomePage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
            {
                LabelGreet.Text = "Guest";
                LogoutButton.Visible = false;
                VProfileButton.Visible = false;
                VUserButton.Visible = false;
                IProductButton.Visible = false;
                UProductButton.Visible = false;
                VProductTypeButton.Visible = false;
                IProductTypeButton.Visible = false;
                UProductTypeButton.Visible = false;
                RefreshGridView();
            }
            else
            {
                int ID = Int32.Parse(Session["ID"].ToString());
                User u = UserRepository.GetUserid(ID);
                if (u.RoleID == 1)
                {
                    LabelGreet.Text = u.Name;
                    LoginButton.Visible = false;
                    VUserButton.Visible = false;
                    IProductButton.Visible = false;
                    UProductButton.Visible = false;
                    VProductTypeButton.Visible = false;
                    IProductTypeButton.Visible = false;
                    UProductTypeButton.Visible = false;
                    RefreshGridView();
                }
                else if (u.RoleID == 2)
                {
                    LabelGreet.Text = u.Name;
                    LoginButton.Visible = false;
                    LabelRecommend.Visible = false;
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void VProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session["ID"] = null;
            Response.Cookies["Email"].Expires = DateTime.Now.AddHours(-1);
            Response.Redirect("HomePage.aspx");
        }

        protected void VProductButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductPage.aspx");
        }

        protected void VProductTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductTypePage.aspx");
        }

        protected void IProductButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductPage.aspx");
        }

        protected void UProductButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductPage.aspx");
        }

        protected void IProductTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductTypePage.aspx");
        }

        protected void UProductTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductTypePage.aspx");
        }

        protected void VUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }
        private void RefreshGridView()
        {
            HomeGridView.DataSource = GetRandomProducts();
            HomeGridView.DataBind();
        }
        private List<Product> GetRandomProducts()
        {
            List<Product> productsList = ProductRepository.GetProducts();
            List<Product> RandomList = new List<Product>();
            Random rand = new Random();
            while (RandomList.Count() != 5)
            {
                int index = rand.Next(0, productsList.Count);
                Product p = productsList[index];
                RandomList.Add(p);
                productsList.RemoveAt(index);
            }
            return RandomList;
        }

    }
}