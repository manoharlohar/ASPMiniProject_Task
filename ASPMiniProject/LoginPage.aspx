<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ASPMiniProject.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            height: 501px;
            margin-right: 0px;
        }
        .auto-style8 {
            width: 76%;
            height: 420px;
        }
        .auto-style9 {
            width: 361px;
        }
        .auto-style10 {
            width: 361px;
            height: 78px;
        }
        .auto-style11 {
            height: 78px;
        }
        .auto-style12 {
            width: 361px;
            height: 89px;
        }
        .auto-style13 {
            height: 89px;
        }
        .auto-style14 {
            width: 361px;
            height: 74px;
        }
        .auto-style15 {
            height: 74px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style7">
        <br />
        <table class="auto-style8">
            <tr>
                <td class="auto-style11" colspan="2"> <h1 style="text-align:center;color:blueviolet;background-color:lightsteelblue;">Login</h1></td>
            </tr>
            <tr>
                <td class="auto-style10">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Position"></asp:Label>
                    &nbsp;</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ddlPosition" runat="server" Height="32px" Width="320px">
                        <asp:ListItem>Team Leader</asp:ListItem>
                        <asp:ListItem>Project Manager</asp:ListItem>
                        <asp:ListItem>Admin</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    &nbsp;</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtEmail" runat="server" Height="32px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                    &nbsp;</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtPassword" runat="server" Height="32px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" BackColor="Teal" Height="52px" Text="Login" Width="141px" OnClick="btnLogin_Click" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
