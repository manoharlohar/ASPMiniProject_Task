using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ASPMiniProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        public string Position { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TLName { get; set; }
        public string AdminName { get; set; }
        public string PMName { get; set; }
        public int PMID { get; set; }
        public int TLID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ClsAspProject obj = new ClsAspProject(ddlPosition.Text.ToString() ,txtEmail.Text, txtPassword.Text);
            SqlDataReader reader = obj.GetUserDetails();
            while (reader.Read())
            {
                Position = reader["Position"].ToString();
                Email = reader["Email"].ToString();
                Password = reader["Password"].ToString();
                PMID= int.Parse(reader["EmployeeId"].ToString());
               TLID= int.Parse(reader["EmployeeId"].ToString());
                TLName= reader["Name"].ToString();
                AdminName= reader["Name"].ToString();
                PMName= reader["Name"].ToString(); ;
                //Email = reader["UEmail"].ToString();
                //  Uid = int.Parse(reader["Uid"].ToString());
            }
            if (txtEmail.Text == Email && txtPassword.Text == Password && ddlPosition.Text.ToString()== "Admin")
            {
                Session["AdminName"] = AdminName;
                Response.Redirect("AllProjects.aspx");

            }
            else if (txtEmail.Text == Email && txtPassword.Text == Password && ddlPosition.Text.ToString() == "Project Manager")
            {
                Session["PMID"] = PMID;
                Session["PMName"] = PMName;

                Response.Redirect("PMDashboard.aspx");

            }
            else if (txtEmail.Text == Email && txtPassword.Text == Password && ddlPosition.Text.ToString() == "Team Leader")
            {
                Session["TLID"] = TLID;
                Session["TLName"] = TLName;
                Response.Redirect("TLDashboard.aspx");

            }
        }
    }
}