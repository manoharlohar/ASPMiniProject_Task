<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="AllEmployees.aspx.cs" Inherits="ASPMiniProject.AllEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        width: 1238px;
        height: 281px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style7">
    <br />
    <asp:GridView ID="gvAllEmployees" runat="server" Height="220px" Width="811px" OnSelectedIndexChanged="gvAllEmployees_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="View Details" ShowHeader="True" Text="View " />
        </Columns>
    </asp:GridView>
</p>
</asp:Content>
