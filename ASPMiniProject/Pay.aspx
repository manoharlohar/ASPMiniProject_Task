<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="ASPMiniProject.Pay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 424px;
        }
        .auto-style2 {
            width: 516px;
        }
    </style>
</head>
<body style="height: 588px">
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style1">
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Label ID="Label6" runat="server" BorderStyle="Outset" Font-Bold="True" Font-Size="25px" Text="Payment Slip" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align:right;padding-right:200px">
                        <asp:Label ID="Label1" runat="server" Text="Project Name"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblpn" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align:right;padding-right:200px">
                        <asp:Label ID="Label2" runat="server" Text="Team Leader"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbltl" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align:right;padding-right:200px">
                        <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblphone" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align:right;padding-right:200px">
                        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align:right;padding-right:200px">
                        <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblAmount" runat="server" Text="Amount"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align:right;padding-right:200px">
                        &nbsp;</td>
                    <td>
                    <asp:Button ID="btnPay" runat="server" Height="47px" OnClick="btnAssignProject_Click" Text="Pay" Width="115px" BackColor="#009933" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
