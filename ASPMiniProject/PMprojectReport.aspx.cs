using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMiniProject
{
    public partial class PMprojectReport : System.Web.UI.Page
    {
        public int PMID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PMID = int.Parse(Session["PMID"].ToString());
            ClsAspProject obj= new ClsAspProject(PMID);
            DataTable dt = obj.GetPMReport();
            gvPMReports.DataSource = dt;
            gvPMReports.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}