<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="PrimaryStockManagement.aspx.cs" Inherits="PrintingProject.PrimaryStockManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" language="javascript">
        function ConfirmOnDelete() {
            if (confirm("آیا از حذف این سطر اطمینان دارید؟") == true)
                return true;
            else
                return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            موجودی اولیه
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <table width="100%">
            <tr>
                <td><span style="font-weight: bold">کد کار و نام کار: &nbsp;</span>
                    <asp:Label ID="lblJobName" runat="server"></asp:Label>
                </td>
                <td style="float: left">
                    <asp:ImageButton ID="btnBack" ImageUrl="Images/back.png" runat="server" OnClick="btnBack_Click" />
                </td>
            </tr>
            <tr>
                <td><span style="font-weight: bold">مانده: &nbsp;</span>
                    <asp:Label ID="lblRemain" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div class="boxgray">
            <table width="100%">
                <tr>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkPrimaryStock" runat="server" BackColor="#99CCFF">موجودی اولیه</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperProductionOrder" runat="server">سفارش تولید</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkProductDelivery" runat="server">تحویل محصول</asp:HyperLink>
                    </td>

                </tr>
            </table>
        </div>
        <table style="padding: 10px">
            <tr>
                <td>مبدا
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFromOrderReceivers" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbFromOrderReceivers"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>مقصد
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbToOrderReceivers"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbToOrderReceivers"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>نوع کار
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbJobTypes"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbJobTypes"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>تعداد کار
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtJobCount" Skin="Web20">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
            </tr>

            <tr>
                <td>توضیحات
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtDescription"
                        TextMode="MultiLine">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button runat="server" ID="btnSave" Text="ثبت" OnClick="btnSave_Click" ValidationGroup="insert" />
                    <asp:Button runat="server" ID="btnEdit" Text="ویرایش" OnClick="btnEdit_Click" ValidationGroup="insert" />
                    <asp:Button runat="server" ID="btnCancel" Text="انصراف" OnClick="btnCancel_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label runat="server" ID="lblMessage"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image4" runat="server" ImageUrl="Images/box_51.png" />
        </div>
        <div style="float: left">
            <asp:Image ID="Image7" runat="server" ImageUrl="Images/box_48.png" />
        </div>
    </div>
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            لیست موجودی های اولیه
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewPrimaryStock" runat="server" AutoGenerateColumns="False"
            ShowHeaderWhenEmpty="True" EmptyDataText="رکوردی موجود نیست." CellPadding="4"
            AllowPaging="True" PageSize="10" Width="100%" OnPageIndexChanging="grdviewPrimaryStock_PageIndexChanging"
            GridLines="None" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Series" HeaderText="سری">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="FromOrderReceivers" HeaderText="مبدا">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="ToOrderReceivers" HeaderText="مقصد">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="JobTypes" HeaderText="نوع کار">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="JobCount" HeaderText="تعداد کار">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                  <asp:BoundField DataField="CreateDatePersian" HeaderText="تاریخ ثبت">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="LoadEditData" runat="server" OnClick="LoadEditData_Click" CssClass='<%# Eval("Id").ToString() %>'
                            ImageUrl="Images/edit.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="Delete" runat="server" OnClick="Delete_Click" OnClientClick="return ConfirmOnDelete();"
                            CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/delete.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"
                            NavigateUrl='<%# "PrintPreviewPage.aspx?PrimaryStockId=" + Eval("Id") %>'></asp:HyperLink>
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
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image3" runat="server" ImageUrl="Images/box_51.png" />
        </div>
        <div style="float: left">
            <asp:Image ID="Image8" runat="server" ImageUrl="Images/box_48.png" />
        </div>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
