<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="ProjectPage.aspx.cs" Inherits="ASPMiniProject.ProjectPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            height: 673px;
        }
        .auto-style8 {
            width: 100%;
            margin-bottom: 69px;
        }
        .auto-style9 {
            height: 74px;
        }
        .auto-style10 {
            height: 79px;
        }
        .auto-style11 {
            height: 77px;
            margin-left: 80px;
        }
        .auto-style12 {
            height: 78px;
        }
        .auto-style13 {
            height: 101px;
        }
        .auto-style14 {
            height: 74px;
            width: 503px;
        }
        .auto-style15 {
            height: 79px;
            width: 503px;
        }
        .auto-style16 {
            height: 77px;
            width: 503px;
        }
        .auto-style17 {
            height: 78px;
            width: 503px;
        }
        .auto-style18 {
            height: 101px;
            width: 503px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center;color:blueviolet;background-color:lightsteelblue;">Project Register</h1>
    <p class="auto-style7">

        <br />
        <table class="auto-style8">
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label5" runat="server" Text="Project Name"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtProjectName" runat="server" Height="28px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="Label1" runat="server" Text="Technology"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtTechnology" runat="server" Height="28px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">
                    <asp:Label ID="Label2" runat="server" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtStartDate" runat="server" Height="28px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Label ID="Label3" runat="server" Text="End Date"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtEndDate" runat="server" Height="28px" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Button ID="btnRegister" runat="server" BackColor="#00CC00" Height="45px" OnClick="btnRegister_Click" Text="Register" Width="144px" />
                </td>
                <td class="auto-style13">
                    <asp:Button ID="btnClear" runat="server" BackColor="#6699FF" Height="46px" OnClick="btnClear_Click" Text="Clear" Width="150px" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
