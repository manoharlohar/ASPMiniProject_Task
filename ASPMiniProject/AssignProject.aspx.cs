using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMiniProject
{
    public partial class AssignProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {



            }
            else
            {
                ClsAspProject clsAspObj = new ClsAspProject();
                DataTable data = clsAspObj.GetAllProjects();
                ddlProjectName.DataSource = data;
                ddlProjectName.DataTextField = "ProjectName";
                ddlProjectName.DataValueField = "ProjectId";
                ddlProjectName.DataBind();

                ClsAspProject clsAspPMObj = new ClsAspProject();
                DataTable GetPM = clsAspPMObj.GetProjectManager();
                ddlPM.DataSource = GetPM;
                ddlPM.DataTextField = "Name";
                ddlPM.DataValueField = "EmployeeId";
                ddlPM.DataBind();
            }
          
        }

        protected void btnAssignProject_Click(object sender, EventArgs e)
        {
            ClsAspProject AssignProObj= new ClsAspProject(int.Parse(ddlPM.SelectedValue.ToString()),int.Parse(ddlProjectName.SelectedValue.ToString()));
            AssignProObj.AssignProject();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

            Response.Redirect("LoginPage.aspx");
        }
    }
}