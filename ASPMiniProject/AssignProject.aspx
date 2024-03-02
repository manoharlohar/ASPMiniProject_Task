<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AssignProject.aspx.cs" Inherits="ASPMiniProject.AssignProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            height: 433px;
        }
        .auto-style8 {
            width: 100%;
            height: 247px;
        }
        .auto-style9 {
            width: 332px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 style="text-align:center">Assign Project</h1>
    <p class="auto-style7">
       
        <br />
        <table class="auto-style8">
            <tr>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Project Name"></asp:Label>
                    &nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlProjectName" runat="server" Height="35px" Width="220px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Project Manager"></asp:Label>
                    &nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlPM" runat="server" Height="35px" Width="220px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAssignProject" runat="server" Height="47px" OnClick="btnAssignProject_Click" Text="Assign" Width="115px" BackColor="#009933" />
                    &nbsp;</td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnClear" runat="server" Height="46px" Text="Clear" Width="96px" BackColor="#3366FF" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogout" runat="server" Text="Logout" Width="182px" BackColor="#CC00FF" BorderColor="#000099" BorderStyle="Outset" BorderWidth="2px" Height="44px" OnClick="btnLogout_Click"  />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
