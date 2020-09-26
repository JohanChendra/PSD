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
    public partial class ChangePasswordPage : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Session["ID"].ToString());
            User u = UserRepository.GetUserid(ID);
            string oldpass = OPtxt.Text;
            string newpass = NPtxt.Text;
            string confirmpass = CPtxt.Text;
            if (oldpass == "" || oldpass != u.Password)
            {
                Labelerror.Text = "Old Password salah";
            }
            else if (newpass =="" || newpass != confirmpass)
            {
                Labelerror.Text = "New Password salah atau konfirmasi password salah";
            }
            else
            {
                UserRepository.UpdateUserPassword(ID, newpass);
                Response.Redirect("ProfilePage.aspx");
            }

        }
    }
}