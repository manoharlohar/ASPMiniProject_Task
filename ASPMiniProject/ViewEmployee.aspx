<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="ViewEmployee.aspx.cs" Inherits="ASPMiniProject.ViewEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 1229px;
            height: 666px;
        }
        .auto-style15 {
            height: 50px;
            width: 465px;
        }
        .auto-style9 {
            height: 50px;
        }
        .auto-style16 {
            height: 46px;
            width: 465px;
        }
        .auto-style10 {
            height: 46px;
        }
        .auto-style17 {
            height: 53px;
            width: 465px;
        }
        .auto-style11 {
            height: 53px;
        }
        .auto-style18 {
            height: 57px;
            width: 465px;
        }
        .auto-style12 {
            height: 57px;
        }
        .auto-style19 {
            height: 54px;
            width: 465px;
        }
        .auto-style13 {
            height: 54px;
        }
        .auto-style8 {
            width: 74%;
            height: 610px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style7">

        <table class="auto-style8" >
            <tr>
                <td class="auto-style15" >
                    <asp:Label ID="Label1" runat="server" Text="Position" ></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
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
                    <asp:DropDownList ID="ddlCity" runat="server" Height="46px" Width="320px" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
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
                    &nbsp;Profile Photo</td>
                <td class="auto-style13">
                    <asp:Image ID="imgProfile" runat="server" Width="265px" Height="270px" />
                    <asp:Label ID="lbldemo" runat="server" Text="lbldemo"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <asp:FileUpload ID="FileUploadEdit" runat="server" />
                </td>
                <td class="auto-style13">
                    <asp:Button ID="btnImg" runat="server" BackColor="#8080C0" OnClick="btnImg_Click" Text="View Image" Width="153px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style13">
                    <asp:Button ID="Button1" runat="server" BackColor="#00FF80" OnClick="Button1_Click" Text="Update" Width="184px" />
                </td>
            </tr>
        </table>
        <br />
    </p>
</asp:Content>
