using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMiniProject
{
    public partial class Pay : System.Web.UI.Page
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public string PaymentStatus { get; set; }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{ 


            //}



            EmployeeId = int.Parse(Request.QueryString["EmployeeId"].ToString());
            ProjectId = int.Parse(Request.QueryString["ProjectId"].ToString());
            PaymentStatus = Request.QueryString["PaymentStatus"].ToString();
            if (IsPostBack)
            { }
            else { 
            lblpn.Text = Request.QueryString["ProjectName"];
            lbltl.Text = Request.QueryString["TeamLeader"];
            lblphone.Text = Request.QueryString["Phone"];
            lblEmail.Text = Request.QueryString["Email"];
            lblAmount.Text = Request.QueryString["Amount"];
            EmployeeId = int.Parse(Request.QueryString["EmployeeId"].ToString());
            ProjectId = int.Parse(Request.QueryString["ProjectId"].ToString());
                if (PaymentStatus == "Paid")
                { 
                btnPay.Enabled = false;
                    btnPay.Text = "Paid";
                }
            }
        }

        protected void btnAssignProject_Click(object sender, EventArgs e)
        {
            ClsAspProject obj= new ClsAspProject(EmployeeId, ProjectId, float.Parse( lblAmount.Text.ToString()));
            obj.AddPayment();

        }
    }
}