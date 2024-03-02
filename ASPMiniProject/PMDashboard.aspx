<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectManagerMaster.Master" AutoEventWireup="true" CodeBehind="PMDashboard.aspx.cs" Inherits="ASPMiniProject.PMDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 101%;
            height: 402px;
        }
        .auto-style10 {
            height: 104px;
        }
        .auto-style11 {
            width: 440px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style9">
        <tr>
            
            <td colspan="2" class="auto-style10"><h2 style="text-align:center;color:blueviolet" >Assign Project</h2></td>
            <td><asp:Label ID="lblpmName" runat="server" Text="Project Name" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label3" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlProject" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Team Leader"></asp:Label>
                &nbsp;</td>
            <td>
                <asp:DropDownList ID="ddlTL" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnAssign" runat="server" BackColor="#009933" Height="41px" OnClick="btnAssign_Click" Text="Assign" Width="100px" />
            </td>
            <td>
                <asp:Button ID="btnClear" runat="server" BackColor="#6600FF" Height="45px" Text="Clear" Width="99px" />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogout" runat="server" Text="Logout" Width="193px" BackColor="#CC00FF" BorderColor="#000099" BorderStyle="Outset" BorderWidth="2px" Height="44px" OnClick="btnLogout_Click"  />
            </td>
        </tr>
    </table>
</asp:Content>
