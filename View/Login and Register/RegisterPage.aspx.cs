using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Factory;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            int roleid = 1;
            string email = Emailtxt.Text;
            string name = Nametxt.Text;
            string password = Passwordtxt.Text;
            string confirmpassword = ConfirmPasswordtxt.Text;
            string gender = RadioButtonListGender.SelectedValue;
            string status = "active";

            if (email == "")
            {
                Labelerror.Text = "email salah";
            }
            else if (name == "")
            {
                Labelerror.Text = "nama salah";
            }
            else if (password == "")
            {
                Labelerror.Text = "password salah";
            }
            else if (password != confirmpassword)
            {
                Labelerror.Text = "confirm password salah";
            }
            else if (gender == "")
            {
                Labelerror.Text = "gender salah";
            }
            else
            {
                UserRepository.InsertUser(roleid, name, email, password, gender, status);
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}