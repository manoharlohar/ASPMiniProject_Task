using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMiniProject
{
    public partial class PaymentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClsAspProject obj= new ClsAspProject();
            DataTable dt = obj.PaymentDetails();
            gvPatmentDetails.DataSource = dt;
            gvPatmentDetails.DataBind();
        }

        protected void gvPatmentDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            int projectId = int.Parse(gvPatmentDetails.SelectedRow.Cells[7].Text.ToString());
            ClsAspProject clsAspProject = new ClsAspProject(projectId);
            clsAspProject.DeleteRecord();
            Response.Redirect("PaymentDetails.aspx");

        }
        bool check = false;

        protected void btnDelete_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}