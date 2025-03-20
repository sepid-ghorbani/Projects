<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="PrintingManagement.aspx.cs" Inherits="PrintingProject.PrintingManagement" %>

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
            سفارش چاپ
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" />
        </div>
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
                        <asp:HyperLink ID="HyperLinkPrinting" runat="server" BackColor="#99CCFF">چاپ</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkPaper" runat="server">کاغذ</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkVeneer" runat="server">روکش</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkLetterPress" runat="server">دایکات</asp:HyperLink>
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
                <td>چاپ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPrinting" Skin="Office2010Blue">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="چاپ جدید (زینک جدید دارد)" Value="1" />
                            <telerik:RadComboBoxItem runat="server" Text="تجدید چاپ" Value="2" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>سفارش گیرنده
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
                <td>مبدا
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFromInstitute"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbFromInstitute"
                        ValidationGroup="insertUsePaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>نوع چاپ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPrintType" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPrintType"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>ابعاد
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtDimension">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>عرض کاغذ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPaperWidth"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPaperWidth"
                        ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>طول کاغذ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPaperHeight"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPaperHeight"
                        ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>نوع زینک
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbZinkType" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbZinkType"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>مدل چاپ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPrintModel" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPrintModel"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
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
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
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
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>تیراژ چاپ
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtPrintingTirazh" MinValue="0" Skin="Web20" AutoPostBack="True" OnTextChanged="txtPrintingTirazh_TextChanged">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                    &nbsp; تعداد محصول: 
                    <asp:Label ID="lblProductCount" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>تعداد ورق بزرگ مصرفی
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtLargePaperCount" MinValue="0" Skin="Web20">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
            </tr>
            <tr>
                <td>سایز کاغذ بزرگ ارسالی
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtLargePaperSize">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>تعداد بند کاغذ ارسالی
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtPaperParagraphCount" MinValue="0"
                        Skin="Web20">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
            </tr>
            <tr>
                <td>تعداد برگ هر بند
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtParagraphLeafCount" MinValue="0"
                        Skin="Web20">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
            </tr>
            <tr>
                <td>تعداد رنگ اصلی
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbMainColorCount"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbMainColorCount"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>رنگ های اصلی چاپ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbExportColor" DataTextField="Name"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbExportColor"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>رنگ چاپ ساختنی Spot
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbSpotColorCount"
                        DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbSpotColorCount"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>نام رنگ های ساختنی Spot
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" TextMode="MultiLine" Width="300px"
                        ID="txtSpotColors">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>نظارت چاپ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPrintingSupervision"
                        Skin="Office2010Blue">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="دارد" Value="true" />
                            <telerik:RadComboBoxItem runat="server" Text="ندارد" Value="false" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>نمونه رنگ
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbColorInstance" Skin="Office2010Blue">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="طبق نمونه ارسالی" Value="1" />
                            <telerik:RadComboBoxItem runat="server" Text="طبق رنگ پنتون" Value="2" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>تعداد دستگاه
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtDeviceCount" MinValue="0" Skin="Web20">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
            </tr>
            <tr>
                <td>تعداد فرم پشت و رو
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtFormEvertCount" MinValue="0" Skin="Web20">
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
                <td>فاکتور
                </td>
                <td>
                    <div class="box">
                        <table>
                            <tr>
                                <td>ردیف
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtInvoiceRow" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>شماره
                                </td>
                                <td>
                                    <telerik:RadNumericTextBox runat="server" ID="txtInvoiceNum" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>مبلغ
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
            لیست چاپ ها
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewPrinting" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
            EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" PageSize="10"
            Width="100%" OnPageIndexChanging="grdviewPrinting_PageIndexChanging" GridLines="None"
            ForeColor="#333333" OnRowDataBound="grdviewPrinting_RowDataBound">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="PrintSeries" HeaderText="سری چاپ">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="OrderReceiverName" HeaderText="سفارش گیرنده">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="PrintTypeName" HeaderText="نوع چاپ">
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
                            NavigateUrl='<%# "PrintPreviewPage.aspx?PrintingId=" + Eval("Id") %>'></asp:HyperLink>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:TemplateField>
                 <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="InsertUsePaper" runat="server" OnClick="InsertUsePaper_Click" ToolTip="مصرف کاغذ" CssClass='<%# Eval("Id").ToString() %>'
                            ImageUrl="Images/task.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="SendToCartex" runat="server" OnClick="SendToCartex_Click" CssClass='<%# Eval("Id").ToString() %>'
                            ImageUrl="Images/move_waiting_up.png" />
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
