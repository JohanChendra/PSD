using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                
            }

            if (Page.IsPostBack == false)
            {
                if (Request.Cookies["Email"] != null)
                {
                   Emailtxt.Text = Request.Cookies["Email"].Value;
                }
            }

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string email = Emailtxt.Text;
            string password = Passwordtxt.Text;

            User u = UserRepository.GetUser(email, password);

            if (u != null)
            {
                if (u.Status =="blocked")
                {
                    Labelerror.Text = "Akun Anda di banned";
                }
                else
                {
                    Session["ID"] = u.ID;
                    if (ChkRM.Checked)
                    {
                        Response.Cookies["Email"].Value = u.Email;
                        Response.Cookies["Email"].Expires = DateTime.Now.AddHours(1);

                    }
                    Response.Redirect("HomePage.aspx");
                }
                
            }
            else
            {
                Labelerror.Text = "Email atau password salah";
            }
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}