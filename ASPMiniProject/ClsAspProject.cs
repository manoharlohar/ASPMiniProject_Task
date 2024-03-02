using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Web;

namespace ASPMiniProject
{
    public class ClsAspProject
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AP5681V\\SQLEXPRESS;Initial Catalog=ASPProjectDB;Integrated Security=True");

        public string Position { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Password { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string ProjectctName { get; set; }
        public string Technology { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int ProjectId { get; set; }
        public int ProjectIdforManager { get; set; }
        public int PMId { get; set; }
        public int TL { get; set; }
        public int Eid { get; set; }
        public float Amount { get; set; }
        public string ProfilePath { get; set; }
        public ClsAspProject(string position,string name,string email,string phone ,int cityId,string password,string profilePath)
        {
            Position=position;
            Name=name;
            Email=email;
            Phone=phone;
            CityId=cityId;
            Password=password;
            ProfilePath=profilePath;

        }
        public ClsAspProject(int empId,string position, string name, string email, string phone, int cityId, string password, string profilePath)
        {   Eid=empId;
            Position = position;
            Name = name;
            Email = email;
            Phone = phone;
            CityId = cityId;
            Password = password;
            ProfilePath = profilePath;

        }

        public ClsAspProject(int empId,int projectId,float amount)
        {
            Eid=empId;
            ProjectId=projectId;
            Amount=amount;
            
        }

        public ClsAspProject(int pmId, int projectId)
        {
            ProjectId = projectId;
            PMId = pmId;

        }
        public ClsAspProject( int projectId, int pmId, int tl)
        {
            ProjectId = projectId;
            PMId = pmId;
            TL= tl;

            
        }

        public ClsAspProject(string position ,string email,string password)
        {
            Position = position;
            Email=email;
            Password=password;
        }
        public ClsAspProject(string projectctName, string technology, string startDate, string endDate)
        {
            ProjectctName = projectctName;
            Technology=technology;
            StartDate=startDate;
            EndDate=endDate;
        }

        public int PMID { get; set; }
        public ClsAspProject(int SelectedId)
        {
            CountryId = SelectedId;
            StateId = SelectedId;
            PMID = SelectedId;
            TL = SelectedId;
            Eid = SelectedId;
        }
        public ClsAspProject()
        {
                
        }

        public void RegisterEmployee()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RegisterEmployee");
            cmd.Parameters.AddWithValue("@Position", Position);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@City", CityId);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@ProfilePath", ProfilePath);

            cmd.ExecuteNonQuery();

            con.Close();

        }


        public void RegisterProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RegisterProject");
            cmd.Parameters.AddWithValue("@ProjectName", ProjectctName);
            cmd.Parameters.AddWithValue("@Technology", Technology);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
           

            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void AddPayment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AddPayment");
            cmd.Parameters.AddWithValue("@EmployeeId", Eid);
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void AssignProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AssignProject");
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            cmd.Parameters.AddWithValue("@PMId", PMId);
            cmd.Parameters.AddWithValue("@StartDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@Status", "Assign");
            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void AssignTL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AssignTL");
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            cmd.Parameters.AddWithValue("@PMId", PMId);
            cmd.Parameters.AddWithValue("@TL", TL);
            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void DeleteRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteRecord");
            cmd.Parameters.AddWithValue("@EmployeeId", Eid);
          
            cmd.ExecuteNonQuery();

            con.Close();

        } 

        public void UpdateFinalStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateFinalStatus");
            cmd.Parameters.AddWithValue("@TL", TL);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetAllProjectstoAdmin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllProjectstoAdmin");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetCompletedtoAdmin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCompletedtoAdmin");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable PaymentDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PaymentDetails");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public DataTable GetAllProjects()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllProjects");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetAllProjectsForTL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllProjectsForTL");
            cmd.Parameters.AddWithValue("@PMId", PMID);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public SqlDataReader GetTLProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTLProject");
            cmd.Parameters.AddWithValue("@TL", TL);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }

        public DataTable GetTeamLeader()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTeamLeader");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public DataTable GetProjectManager()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetProjectManager");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetCountries()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCountries");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetStatesByCountryId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetStatesByCountryId");
            cmd.Parameters.AddWithValue("@CountryId", CountryId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetCityByStateId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCityByStateId");
            cmd.Parameters.AddWithValue("@State", StateId);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetPMReport()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPMReport");
            cmd.Parameters.AddWithValue("@PMId", PMID);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public SqlDataReader GetUserDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetUserDetails");
            cmd.Parameters.AddWithValue("@Position", Position);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }


        public DataTable ViewEmployees()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ViewEmployees");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public SqlDataReader EmployeeDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EmployeeDetails");
            cmd.Parameters.AddWithValue("@EmployeeId", Eid);
           
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void UpdateDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ASPProjectProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateDetails");
            cmd.Parameters.AddWithValue("@EmployeeId", Eid);
            cmd.Parameters.AddWithValue("@Position", Position);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@City", CityId);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@ProfilePath", ProfilePath);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}