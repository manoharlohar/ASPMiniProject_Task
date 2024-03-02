using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMiniProject
{
    public partial class CompletedProjects : System.Web.UI.Page
    {
        public string ProjectName { get; set; }
        public string TeamLeader { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int EmployeeId { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string AdminName = Session["AdminName"].ToString();
            lblAdmin.Text = AdminName;
            ClsAspProject projectObj = new ClsAspProject();
            gvAllProjects.DataSource = projectObj.GetCompletedtoAdmin();
            gvAllProjects.DataBind();
        }

        protected void gvAllProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pn= gvAllProjects.SelectedRow.Cells[1].Text;
            ProjectName = gvAllProjects.SelectedRow.Cells[1].Text;
            TeamLeader = gvAllProjects.SelectedRow.Cells[2].Text;
            Phone = gvAllProjects.SelectedRow.Cells[3].Text;
            Email = gvAllProjects.SelectedRow.Cells[4].Text;
            string PaymentStatus = gvAllProjects.SelectedRow.Cells[12].Text;
            EmployeeId = int.Parse(gvAllProjects.SelectedRow.Cells[10].Text.ToString());
            int projectId = int.Parse(gvAllProjects.SelectedRow.Cells[11].Text.ToString());
            string amount = "50000";
             Response.Redirect("Pay.aspx?ProjectName="+ProjectName+"&TeamLeader="+TeamLeader+"&Phone="+Phone+"&Email="+Email+"&Amount="+amount+"&EmployeeId="+EmployeeId+"&ProjectId="+projectId+"&PaymentStatus="+PaymentStatus);

        }
    }
}