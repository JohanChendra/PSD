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
    public partial class ProfilePage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Session["ID"].ToString());
            User u = UserRepository.GetUserid(ID);
            LabelEmail.Text = u.Email;
            LabelName.Text = u.Name;
            LabelGender.Text = u.Gender;
        }

        protected void UProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfilePage.aspx");
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePasswordPage.aspx");
        }
    }
}