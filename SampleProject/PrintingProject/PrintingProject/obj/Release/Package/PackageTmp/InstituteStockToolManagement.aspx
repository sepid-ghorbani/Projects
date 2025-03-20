<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="InstituteStockToolManagement.aspx.cs" Inherits="PrintingProject.InstituteStockToolManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            جستجوی موجودی بنگاه ها
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <table>
            <tr>
                <td>
                    <img src="Images/menu/Submenu/search.png" />
                </td>
                <td>
                    <br />
                    جهت جستجو موارد زیر را انتخاب نمایید.
                </td>
            </tr>
        </table>
        <table style="padding: 10px">
            <tr>
                <td>بنگاه
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbInstitute" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbInstitute"
                        ValidationGroup="search" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>نوع جنس مصرفی
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbMaterialType" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbMaterialType"
                        ValidationGroup="search" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>گرماژ جنس مصرفی
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbMaterialTypeGramazh"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbMaterialTypeGramazh"
                        ValidationGroup="search" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>عرض کاغذ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPaperWidth" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPaperWidth"
                        ValidationGroup="search" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>طول کاغذ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPaperHeight" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPaperHeight"
                        ValidationGroup="search" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button runat="server" ID="btnSearch" Text="جستجو" ValidationGroup="search" OnClick="btnSearch_Click" />
                </td>
            </tr>
            <tr>
                <td>موجودی 
                </td>
                <td>
                   <asp:GridView ID="grdviewStock" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="رکوردی موجود نیست."
                        CellPadding="4" Width="250"
                       
                        GridLines="None" ForeColor="#333333">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstituteName" HeaderText="نام بنگاه">
                                <HeaderStyle HorizontalAlign="Right"  Width="150px" />
                                <ItemStyle HorizontalAlign="Right"  Width="150px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="LeafCount" HeaderText="موجودی">
                                <HeaderStyle HorizontalAlign="Right"  Width="100px" />
                                <ItemStyle HorizontalAlign="Right"  Width="100px"/>
                            </asp:BoundField>
                           
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

                </td>
            </tr>
        </table>
        <br />
        <br />

    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image4" runat="server" ImageUrl="Images/box_51.png" />
        </div>
        <div style="float: left">
            <asp:Image ID="Image7" runat="server" ImageUrl="Images/box_48.png" />
        </div>
    </div>
</asp:Content>
