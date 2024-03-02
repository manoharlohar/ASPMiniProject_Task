<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AllProjects.aspx.cs" Inherits="ASPMiniProject.AllProjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        height: 439px;
    }
        .auto-style8 {
            margin-top: 73px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style7">
    <br />
        <asp:Label ID="lblAdmin" runat="server" Text="Label" Visible="False"></asp:Label>
    <asp:GridView ID="gvAllProjects" runat="server" Height="350px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="751px" CssClass="auto-style8" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Pay" ShowHeader="True" Text="Pay" />
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
        <asp:Button ID="btnLogout" runat="server" Text="Logout" Width="180px" BackColor="#CC00FF" BorderColor="#000099" BorderStyle="Outset" BorderWidth="2px" OnClick="btnLogout_Click"  />
</p>
</asp:Content>
