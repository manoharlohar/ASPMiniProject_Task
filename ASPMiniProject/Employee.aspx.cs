using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMiniProject
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {


                //int i = Convert.ToInt32(DropDownListStud.SelectedValue.ToString());
                //ClsAsp obj = new ClsAsp(i);

                //SqlDataReader reader = obj.GetStudDetails();
                //while (reader.Read())
                //{


                //    //Textname.Text = reader["UName"].ToString();
                //    //txtpaass.Text = reader["Password"].ToString();

                //}

            }
            else {
                //ImgProfile.Visible = false;

                ClsAspProject obj = new ClsAspProject();
                DataTable contry = obj.GetCountries();
                ddlCountry.DataSource = contry;
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryId";
                ddlCountry.DataBind();

               
                ddlCountry.Text = "--Select--";
                ddlState.Text = "--Select--";
            }
           
           



            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (FileUploadProfile.HasFile)
            {
                FileUploadProfile.SaveAs(Server.MapPath("~/ProfileImg/")+System.IO.Path.GetFileName(FileUploadProfile.FileName));
                string ProfilePath= "ProfileImg/"+ System.IO.Path.GetFileName(FileUploadProfile.FileName);
                ClsAspProject empObj = new ClsAspProject(ddlPosition.SelectedValue.ToString(), txtName.Text.ToString(), txtEmail.Text.ToString(), txtPhone.Text.ToString(), int.Parse(ddlCity.SelectedValue.ToString()), txtPassword.Text.ToString(), ProfilePath);
                empObj.RegisterEmployee();
                Response.Redirect("Employee.aspx");
            }
           
           

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            ddlPosition.Text = "--Select--";
            ddlCountry.Text = "--Select--";
            ddlState.Text = "--Select--";
        }

        protected void ddlPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        protected void btnAddImg_Click(object sender, EventArgs e)
        {
           


        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}