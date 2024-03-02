using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMiniProject
{
    public partial class ProjectPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            ClsAspProject ProjectObj= new ClsAspProject(txtProjectName.Text.ToString(),txtTechnology.Text.ToString(),txtStartDate.Text.ToString(),txtEndDate.Text.ToString());
            ProjectObj.RegisterProject();
            Response.Redirect("ProjectPage.aspx");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}