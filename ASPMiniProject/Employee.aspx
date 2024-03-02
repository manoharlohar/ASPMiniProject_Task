<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="ASPMiniProject.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 74%;
            height: 610px;
        }
        .auto-style9 {
            height: 50px;
        }
        .auto-style10 {
            height: 46px;
        }
        .auto-style11 {
            height: 53px;
        }
        .auto-style12 {
            height: 57px;
        }
        .auto-style13 {
            height: 54px;
        }
        .auto-style14 {
            height: 56px;
        }
        .auto-style15 {
            height: 50px;
            width: 465px;
        }
        .auto-style16 {
            height: 46px;
            width: 465px;
        }
        .auto-style17 {
            height: 53px;
            width: 465px;
        }
        .auto-style18 {
            height: 57px;
            width: 465px;
        }
        .auto-style19 {
            height: 54px;
            width: 465px;
        }
        .auto-style20 {
            height: 56px;
            width: 465px;
        }
    .auto-style22 {
        height: 316px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1 style="text-align:center;color:blueviolet;background-color:lightsteelblue;">Employee Register</h1>

        <table class="auto-style8" >
            <tr>
                <td class="auto-style15" >
                    <asp:Label ID="Label1" runat="server" Text="Position" ></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:DropDownList ID="ddlPosition" runat="server" Height="28px" Width="320px" AutoPostBack="True" OnSelectedIndexChanged="ddlPosition_SelectedIndexChanged">
                        <asp:ListItem>Team Leader</asp:ListItem>
                        <asp:ListItem>Project Manager</asp:ListItem>
                        <asp:ListItem>Admin</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">
                    <asp:Label ID="Label2" runat="server" Text="Name" ></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtName" runat="server" Height="28px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Label ID="Label3" runat="server" Text="Email" ></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtEmail" runat="server" Height="28px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="Label4" runat="server" Text="Phone" ></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtPhone" runat="server" Height="28px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="Label5" runat="server" Text="Country" ></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:DropDownList ID="ddlCountry" runat="server" Height="28px" Width="320px" AutoPostBack="True" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="Label6" runat="server" Text="State" ></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:DropDownList ID="ddlState" runat="server" Height="28px" Width="320px" AutoPostBack="True" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    City</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="ddlCity" runat="server" Height="28px" Width="320px" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="Label7" runat="server" Text="Password" ></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtPassword" runat="server" Height="28px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    Add Profile Photo</td>
                <td class="auto-style13">
                    <asp:FileUpload ID="FileUploadProfile" runat="server" Width="414px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style22" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Button ID="btnRegister" runat="server" BackColor="#00CC00" Height="45px" OnClick="btnRegister_Click" Text="Register" Width="144px" />
                </td>
                <td class="auto-style14">
                    <asp:Button ID="btnClear" runat="server" BackColor="#6699FF" Height="46px" OnClick="btnClear_Click" Text="Clear" Width="150px" />
                </td>
            </tr>
        </table>
</asp:Content>
