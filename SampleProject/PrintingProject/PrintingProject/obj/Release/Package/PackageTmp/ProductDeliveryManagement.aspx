<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProductDeliveryManagement.aspx.cs" Inherits="PrintingProject.ProductDeliveryManagement" %>

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
            تحویل محصول
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <jq:JQLoader ID="JQLoader1" Theme="Redmond" runat="server">
        </jq:JQLoader>
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
                        <asp:HyperLink ID="HyperLinkPrimaryStock" runat="server">موجودی اولیه</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperProductionOrder" runat="server">سفارش تولید</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkProductDelivery" runat="server" BackColor="#99CCFF">تحویل محصول</asp:HyperLink>
                    </td>

                </tr>
            </table>
        </div>
        <table style="padding: 10px">
            <tr>
                <td>سفارش گیرنده
                </td>
                <td>
                    <asp:Label runat="server" ID="lblOrderReceiver"></asp:Label>
                  
                </td>
            </tr>
            <tr>
                <td>تحویل گیرنده
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbDeliveryReceivers"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>نوع کار
                </td>
                <td>
                    <asp:Label runat="server" ID="lblJobType"></asp:Label>
                
                </td>
            </tr>
            <tr>
                <td>تعداد تحویل
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtDeliveryCount" MinValue="0" Skin="Web20" AutoPostBack="True" OnTextChanged="txtDeliveryCount_TextChanged">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtDeliveryCount"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>فی 1
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtFee1" MinValue="0" Skin="Web20">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtFee1"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>جمع مبلغ 
                </td>
                <td>
                    <asp:Label ID="lblCostSum1" runat="server"></asp:Label>

                </td>
            </tr>
            <tr>
                <td>تاریخ تحویل
                </td>
                <td>
                    <jq:JQDatePicker ID="dtpDeliveryDate" runat="server" ShowSelectButton="True" Regional="fa"
                        Width="156px" ButtonImage="Images/x_office_calendar.png"></jq:JQDatePicker>

                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="dtpDeliveryDate"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>شماره رسید
                </td>
                <td>
                    <telerik:RadTextBox runat="server"  Skin="Web20" ID="txtReceiptNum">
                    </telerik:RadTextBox>
                    
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtReceiptNum"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
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
                <td>فاکتور ورودی
                </td>
                <td>
                    <div class="box">
                        <table>
                            <tr>
                                <td>تاریخ
                                </td>
                                <td>
                                    <jq:JQDatePicker ID="dtpInputInvoiceDate" runat="server" ShowSelectButton="True" Regional="fa"
                                        Width="156px" ButtonImage="Images/x_office_calendar.png"></jq:JQDatePicker>
                                </td>
                            </tr>
                            <tr>
                                <td>ردیف
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtInputInvoiceRow" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>شماره
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtInputInvoiceNum" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>مبلغ
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtInputInvoiceCost" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td>فاکتور خروجی
                </td>
                <td>
                    <div class="box">
                        <table>
                            <tr>
                                <td>تاریخ
                                </td>
                                <td>
                                    <jq:JQDatePicker ID="dtpOutputInvoiceDate" runat="server" ShowSelectButton="True" Regional="fa"
                                        Width="156px" ButtonImage="Images/x_office_calendar.png"></jq:JQDatePicker>
                                </td>
                            </tr>
                            <tr>
                                <td>ردیف
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtOutputInvoiceRow" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>شماره
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtOutputInvoiceNum" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>مبلغ
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtOutputInvoiceCost" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox><asp:Label ID="lblCostSum2" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
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
            لیست تحویل های محصول
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewProductDelivery" runat="server" AutoGenerateColumns="False"
            ShowHeaderWhenEmpty="True" EmptyDataText="رکوردی موجود نیست." CellPadding="4"
            AllowPaging="True" Width="100%" OnPageIndexChanging="grdviewProductDelivery_PageIndexChanging"
            GridLines="None" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Series" HeaderText="سری">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="OrderReceivers" HeaderText="سفارش گیرنده">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                 <asp:BoundField DataField="JobTypes" HeaderText="نوع کار">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="DeliveryCount" HeaderText="تعداد تحویل">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="InputInvoiceCost" HeaderText="جمع مبلغ ورودی" DataFormatString="{0:N}">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="InputInvoiceNum" HeaderText="شماره فاکتور ورودی">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="OutputInvoiceCost" HeaderText="جمع مبلغ خروجی" DataFormatString="{0:N}">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="OutputInvoiceNum" HeaderText="شماره فاکتور خروجی">
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
                            NavigateUrl='<%# "PrintPreviewPage.aspx?ProductDeliveryId=" + Eval("Id") %>'></asp:HyperLink>
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
