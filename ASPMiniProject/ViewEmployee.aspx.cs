using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ASPMiniProject
{
    public partial class ViewEmployee : System.Web.UI.Page
    {
        public int EmpId { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsAspProject obj = new ClsAspProject();
                DataTable contry = obj.GetCountries();
                ddlCountry.DataSource = contry;
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryId";
                ddlCountry.DataBind();

                EmpId = int.Parse(Session["EmployeeId"].ToString());
                ClsAspProject obj1 = new ClsAspProject(EmpId);
                SqlDataReader reader = obj1.EmployeeDetails();
                while (reader.Read())
                {
                   // ddlPosition.Text = reader["Position"].ToString();
                    txtName.Text = reader["Name"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    ddlCountry.SelectedValue =reader["CountryId"].ToString();
                    ddlState.SelectedValue =reader["StateId"].ToString();
                   // ddlState.Text =reader["StateName"].ToString();
                    ddlCity.SelectedValue =reader["CityId"].ToString();
                  //  ddlCity.Text =reader["CityName"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    string url= reader["ProfilePhoto"].ToString();
                  imgProfile.ImageUrl= "~/" + url;

                }
            }
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsAspProject StatesObj = new ClsAspProject(int.Parse(ddlCountry.SelectedValue.ToString()));
            DataTable states = StatesObj.GetStatesByCountryId();
            ddlState.DataSource = states;
            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateId";
            ddlState.DataBind();
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsAspProject CityObj = new ClsAspProject(int.Parse(ddlState.SelectedValue.ToString()));
            DataTable states = CityObj.GetCityByStateId();
            ddlCity.DataSource = states;
            ddlCity.DataTextField = "CityName";
            ddlCity.DataValueField = "CityId";
            ddlCity.DataBind();
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string ProfilePath { get; set; }
        protected void btnImg_Click(object sender, EventArgs e)
        {
            if (FileUploadEdit.HasFile)
            {
                FileUploadEdit.SaveAs(Server.MapPath("~/ProfileImg/") + System.IO.Path.GetFileName(FileUploadEdit.FileName));
                 ProfilePath = "ProfileImg/" + System.IO.Path.GetFileName(FileUploadEdit.FileName);
                imgProfile.ImageUrl = "~/" + ProfilePath;
                lbldemo.Text = "ProfileImg/" + System.IO.Path.GetFileName(FileUploadEdit.FileName);


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int EmployeeId = int.Parse(Session["EmployeeId"].ToString());
            ClsAspProject empObj = new ClsAspProject(EmployeeId, "Project Manager", txtName.Text.ToString(), txtEmail.Text.ToString(), txtPhone.Text.ToString(), int.Parse(ddlCity.SelectedValue.ToString()), txtPassword.Text.ToString(), lbldemo.Text.ToString());
            empObj.UpdateDetails();
            Response.Write(" Record Updated ");
        }
    }
}