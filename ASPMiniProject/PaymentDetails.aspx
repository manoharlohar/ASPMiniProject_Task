<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="PaymentDetails.aspx.cs" Inherits="ASPMiniProject.PaymentDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        width: 757px;
        height: 428px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style7">
    <br />
        <asp:Button ID="btnDelete" runat="server" BackColor="#FF9933" BorderColor="#003399" BorderStyle="Outset" BorderWidth="2px" OnClick="btnDelete_Click" Text="Delete" />
    <asp:GridView ID="gvPatmentDetails" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="306px" OnSelectedIndexChanged="gvPatmentDetails_SelectedIndexChanged" Width="551px">
        <AlternatingRowStyle BackColor="White" />
       <%-- <Columns>

                        <asp:TemplateField >
                             <ItemTemplate>
                                 <asp:CheckBox ID="myCheckBox" runat="server" />
                             </ItemTemplate>
                         </asp:TemplateField>

                  </Columns>--%>
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Delete" ShowHeader="True" Text="Delete" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</p>
</asp:Content>
