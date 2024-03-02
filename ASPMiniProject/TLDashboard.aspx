<%@ Page Title="" Language="C#" MasterPageFile="~/TLMaster.Master" AutoEventWireup="true" CodeBehind="TLDashboard.aspx.cs" Inherits="ASPMiniProject.TLDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 990px;
            height: 531px;
        }
        .auto-style6 {
            width: 100%;
            height: 410px;
        }
        .auto-style7 {
            margin-left: 40px;
        }
        .auto-style9 {
            width: 365px;
        }
        .auto-style10 {
            width: 367px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style5">
        <br />
        <table class="auto-style6">
            <tr>
                <td class="auto-style7" colspan="3" style="text-align:right;padding-right:100px;background-color:lightsteelblue">
                    <asp:Label ID="lblTLName" runat="server" Text="TL Name" Font-Size="30px" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align:center;background-color:lightsteelblue">
                    <asp:Label ID="lblProjectName" runat="server" Text="Project Name" Font-Size="35px" BorderStyle="Outset"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10" style="text-align:center">
                    <asp:Label ID="lblPNItr3" runat="server" Font-Size="30px" Text="PN"></asp:Label>
                </td>
                <td class="auto-style9" style="text-align:center">
                    <asp:Label ID="Label1" runat="server" Font-Size="30px" Text="Iteration  1"></asp:Label>
                </td>
                <td style="text-align:center">
                    <asp:Button ID="btnItr1" runat="server" BackColor="#00CC66" BorderStyle="Outset" Height="42px" OnClick="btnItr1_Click" Text="Active" Width="112px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10" style="text-align:center">
                    <asp:Label ID="lblPNItr1" runat="server" Font-Size="30px" Text="PN"></asp:Label>
                </td>
                <td class="auto-style9" style="text-align:center">
                    <asp:Label ID="Label2" runat="server" Font-Size="30px" Text="Iteration  2"></asp:Label>
                </td>
                <td style="text-align:center">
                    <asp:Button ID="btnItr2" runat="server" BackColor="#00CC66" BorderStyle="Outset" Height="38px" OnClick="btnItr2_Click" Text="Active" Width="106px" Enabled="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10" style="text-align:center">
                    <asp:Label ID="lblPNItr2" runat="server" Font-Size="30px" Text="PN"></asp:Label>
                </td>
                <td class="auto-style9" style="text-align:center">
                    <asp:Label ID="Label3" runat="server" Font-Size="30px" Text="Iteration  3"></asp:Label>
                </td>
                <td style="text-align:center">
                    <asp:Button ID="btnItr3" runat="server" BackColor="#00CC66" BorderStyle="Outset" Height="41px" OnClick="btnItr3_Click" Text="Active" Width="111px" Enabled="False" />
                </td>
            </tr>
        </table>
        <div style="text-align:center">
             <asp:Label ID="lblMsg" runat="server" Font-Size="30px" Text="."></asp:Label>
        </div>
                   
                <div style="text-align:center">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" Width="180px" BackColor="#CC00FF" BorderColor="#000099" BorderStyle="Outset" BorderWidth="2px" OnClick="btnLogout_Click"  />
                </div>
    </p>
</asp:Content>
