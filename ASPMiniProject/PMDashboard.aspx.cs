using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ASPMiniProject
{
    public partial class PMDashboard : System.Web.UI.Page
    {
        public int PMID { get; set; }
        public string PNName { get; set; }
        public int count { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(count==0)
            {
                PNName = Session["PMName"].ToString();
                PMID = int.Parse(Session["PMID"].ToString());
                lblpmName.Text = PNName;
                ++count;
            }
           
            if (IsPostBack)
            {
                

            }
            else
            {
                

                ClsAspProject clsAspObj = new ClsAspProject(PMID);
                DataTable data = clsAspObj.GetAllProjectsForTL();
                ddlProject.DataSource = data;
                ddlProject.DataTextField = "ProjectName";
                ddlProject.DataValueField = "ProjectId";
                ddlProject.DataBind();

                ClsAspProject TLObj = new ClsAspProject();
                DataTable TealLeader = clsAspObj.GetTeamLeader();
                ddlTL.DataSource = TealLeader;
                ddlTL.DataTextField = "Name";
                ddlTL.DataValueField = "EmployeeId";
                ddlTL.DataBind();
            }
        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            ClsAspProject obj = new ClsAspProject(int.Parse(ddlProject.SelectedValue.ToString()), PMID, int.Parse(ddlTL.SelectedValue.ToString()));
            obj.AssignTL();
            Response.Redirect("PMDashboard.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}