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
    public partial class ViewUser : System.Web.UI.Page
    {
        TokoBeDiaEntities db = new TokoBeDiaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SubmitButton.Visible = false;
                LabelNewRole.Visible = false;
                NewRoletxt.Visible = false;
                LabelID.Visible = false;       
                RefreshGridView();
            }            
        }

        private void RefreshGridView()
        {
            UserGridView.DataSourceID = "UserDataSource";
            UserGridView.DataBind();
        }

        protected void RoleButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Session["ID"].ToString());
            int rowindex = Int32.Parse((sender as Button).CommandArgument);
            LabelID.Text = rowindex.ToString();
            User u = UserRepository.GetUserid(rowindex);
            if (ID == rowindex)
            {
                Labelerror.Text = "Tidak bisa mengganti role diri sendiri";
            }
            else
            {
                LabelNewRole.Visible = true;
                NewRoletxt.Visible = true;
                SubmitButton.Visible = true;
            }
        }

        protected void StatusButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Session["ID"].ToString());
            int rowindex = Int32.Parse((sender as Button).CommandArgument);
            User u = UserRepository.GetUserid(rowindex);
            if (ID == rowindex)
            {
                Labelerror.Text = "Tidak bisa mengganti status diri sendiri";
            }
            else
            {
                if (u.Status == "active") 
                {
                    u.Status = "blocked";
                }
                else if (u.Status =="blocked")
                {
                    u.Status = "active";
                }
                UserRepository.ChangeUserStatus(u.ID, u.Status);
            }
            RefreshGridView();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(LabelID.Text.ToString());
            if (NewRoletxt.Text == "")
            {
                Labelerror.Text = "New Role kosong";
            }
            else
            {
                int role = Int32.Parse(NewRoletxt.Text.ToString());
                if (role == 1 || role == 2)
                {
                    UserRepository.ChangeUserRole(id, role);
                    RefreshGridView();
                    Response.Redirect("ViewUser.aspx");
                }
                else
                { 
                    Labelerror.Text = "Role yang anda input salah";
                }
            }
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}