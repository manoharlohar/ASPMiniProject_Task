using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ASPMiniProject
{
    public partial class AllEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClsAspProject clsAspProject = new ClsAspProject();
            DataTable dt= clsAspProject.ViewEmployees();
            gvAllEmployees.DataSource = dt;
            gvAllEmployees.DataBind();
        }

        protected void gvAllEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int EmpId = int.Parse(gvAllEmployees.SelectedRow.Cells[1].Text.ToString());
            Session["EmployeeId"] = EmpId;
            Response.Redirect("ViewEmployee.aspx");

        }
    }
}