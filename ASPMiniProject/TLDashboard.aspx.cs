using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMiniProject
{
    public partial class TLDashboard : System.Web.UI.Page
    {
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string TLName { get; set; }
        public int TLID { get; set; }
        public int count { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (count == 0)
            {
                TLName = Session["TLName"].ToString();
                TLID = int.Parse(Session["TLID"].ToString());
                lblTLName.Text = TLName;
                ++count;
            }
             if (IsPostBack)
            { 
            
            }
            else {

                lblMsg.Visible = false;
                ClsAspProject obj = new ClsAspProject(TLID);
                SqlDataReader reader = obj.GetTLProject();
                while (reader.Read())
                {
                    ProjectName = reader["ProjectName"].ToString();
                    Status = reader["Status"].ToString();

                }
                lblProjectName.Text = ProjectName;
                lblPNItr1.Text = ProjectName;
                lblPNItr2.Text = ProjectName;
                lblPNItr3.Text = ProjectName;

                if (Status == "Completed")
                {
                    btnItr1.Text = "Completed";
                    btnItr2.Text = "Completed";
                    btnItr3.Text = "Completed";
                    btnItr1.Enabled = false;
                    btnItr2.Enabled = false;
                    btnItr3.Enabled = false;
                }
            }
            

        }

        protected void btnItr1_Click(object sender, EventArgs e)
        {

            btnItr1.Text = "Completed";
            btnItr2.Enabled = true;

        }

        protected void btnItr2_Click(object sender, EventArgs e)
        {
            if (btnItr1.Text == "Completed")
            {
                btnItr2.Text = "Completed";
                btnItr3.Enabled = true;

            }

        }

        protected void btnItr3_Click(object sender, EventArgs e)
        {
            if (btnItr1.Text == "Completed"&& btnItr1.Text == "Completed")
            {
                btnItr3.Text = "Completed";
               

            }

            ClsAspProject obj = new ClsAspProject(TLID);
                obj.UpdateFinalStatus();
                lblMsg.Visible = true;
                lblMsg.Text = "Project Status is Completed";
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}