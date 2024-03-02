<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectManagerMaster.Master" AutoEventWireup="true" CodeBehind="PMprojectReport.aspx.cs" Inherits="ASPMiniProject.PMprojectReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style8 {
        width: 858px;
        height: 441px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style8">
        <br />
    <asp:GridView ID="gvPMReports" runat="server" Height="281px" Width="794px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView>
</p>
</asp:Content>
