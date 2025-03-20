<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="LetterPressManagement.aspx.cs" Inherits="PrintingProject.LetterPressManagement" %>

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
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            بخش دایکات
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
      <table width="100%">
            <tr>
                <td><span style="font-weight: bold">شماره دستور کار و نام کار: &nbsp;</span>
                    <asp:Label ID="lblJobName" runat="server"></asp:Label>
                </td>
                <td style="float: left">
                    <asp:ImageButton ID="btnBack" ImageUrl="Images/back.png" runat="server" OnClick="btnBack_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <span style="font-weight: bold">تاریخ دستورکار: &nbsp;</span>
                      <asp:Label ID="lblJobCreateDate" runat="server"></asp:Label>
                    &nbsp;
                    <span style="font-weight: bold"> کد کار: &nbsp;</span>
                      <asp:Label ID="lblJobCode" runat="server"></asp:Label>
                </td>
                <td>
                   

                </td>
            </tr>
        </table>
        <div class="boxgray">
            <table width="100%">
                <tr>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkLitography" runat="server">لیتوگرافی</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkPrinting" runat="server">چاپ</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkPaper" runat="server">کاغذ</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkVeneer" runat="server">روکش</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkLetterPress" runat="server" BackColor="#99CCFF">دایکات</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkMakingTemplate" runat="server">قالب</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkSahafi" runat="server">صحافی</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkFinalInvoice" runat="server">فاکتور</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
        <table style="padding: 10px">
            <tr>
                <td>
                    سفارش گیرنده
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbOrderReceiver" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbOrderReceiver"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    نوع دایکات
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbLetterPressType"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbLetterPressType"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    تیراژ
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtTirazh" MinValue="0" Skin="Web20">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    ابعاد
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtDimension">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    گرماژ کاغذ
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtPaperGramazh">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    توضیحات
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtDescription"
                        TextMode="MultiLine">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    فاکتور
                </td>
                <td>
                    <div class="box">
                        <table>
                            <tr>
                                <td>
                                    ردیف
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtInvoiceRow" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    شماره
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtInvoiceNum" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    مبلغ
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtInvoiceCost" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                </td>
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
            <asp:Image ID="Image4" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image7" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            لیست دایکات ها
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewLetterPress" runat="server" AutoGenerateColumns="False"
            ShowHeaderWhenEmpty="True" EmptyDataText="رکوردی موجود نیست." CellPadding="4"
            AllowPaging="True" PageSize="10" Width="100%" OnPageIndexChanging="grdviewLetterPress_PageIndexChanging"
            GridLines="None" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="OrderSeries" HeaderText="سری">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="OrderReceiverName" HeaderText="سفارش گیرنده">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="LetterPressTypeName" HeaderText="نوع دایکات">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Description" HeaderText="توضیحات">
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
                            NavigateUrl='<%# "PrintPreviewPage.aspx?LetterPressId=" + Eval("Id") %>'></asp:HyperLink>
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
            <asp:Image ID="Image3" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image8" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
