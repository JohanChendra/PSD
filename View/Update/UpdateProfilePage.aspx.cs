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
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int ID = Int32.Parse(Session["ID"].ToString());
                ViewData(ID);
            }
            
        }
        private void ViewData(int ID)
        {
            User u = UserRepository.GetUserid(ID);
            Emailtxt.Text = u.Email;
            Nametxt.Text = u.Name;
            RadioButtonListGender.SelectedValue = u.Gender;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Session["ID"].ToString());
            string email = Emailtxt.Text;
            string name = Nametxt.Text;
            string gender = RadioButtonListGender.SelectedValue;
            

            if (email == "")
            {
                Labelerror.Text = "email salah";
            }
            else if (name == "")
            {
                Labelerror.Text = "nama salah";
            }
            else if (gender == "")
            {
                Labelerror.Text = "gender salah";
            }
            else
            {
                UserRepository.UpdateUserProfile(ID, email, name, gender);
                Response.Redirect("ProfilePage.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }
    }
}