<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="PermissionManagement.aspx.cs" Inherits="PrintingProject.PermissionManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <table>
            <tr>
                <td>
                    <img src="Images/Menu/Submenu/computer_process.png" />
                </td>
                <td>
                    <br />
                    تنظیمات دسترسی کاربران
                </td>
            </tr>
        </table>
        <table style="padding: 10px" width="100%">
            <tr>
                <td style="width: 200px">
                    نام کاربر مورد نظر را انتخاب نمایید:
                </td>
                <td>
                    <telerik:RadComboBox runat="server" MarkFirstMatch="True" ID="cmbUsers" Skin="Office2010Blue"
                        OnSelectedIndexChanged="cmbUsers_SelectedIndexChanged" AutoPostBack="True">
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <br />
                    <asp:GridView ID="grdviewPages" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        ForeColor="#333333" GridLines="None" Width="100%" EmptyDataText="رکوردی موجود نیست."
                        ShowHeaderWhenEmpty="True">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="نام صفحات">
                                <HeaderStyle HorizontalAlign="Right" />
                                <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="انتخاب">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Right" />
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkboxSelect" runat="server" CssClass='<%# Eval("Id").ToString() %>' />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="80px" />
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#00acc8" ForeColor="White" Font-Bold="True" />
                        <HeaderStyle BackColor="#00acc8" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#7c868d" ForeColor="White" HorizontalAlign="Center" CssClass="pagination" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="float: left">
                    <asp:Label runat="server" ID="lblMessage"></asp:Label>
                    <asp:Button runat="server" ID="btnSavePermissions" Text="ثبت دسترسی" OnClick="btnSavePermissions_Click" />
                </td>
            </tr>
        </table>
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image4" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image7" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
