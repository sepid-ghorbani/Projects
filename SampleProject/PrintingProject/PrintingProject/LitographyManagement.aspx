<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="LitographyManagement.aspx.cs" Inherits="PrintingProject.LitographyManagement" %>

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
            سفارش لیتوگرافی
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
       
        <div class="boxgray" >
            <table width="100%">
                <tr>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkLitography" runat="server" BackColor="#99CCFF">لیتوگرافی</asp:HyperLink>
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
           
        <telerik:RadTabStrip Font-Names="Tahoma" Align="Right" Font-Size="11pt" ID="RadTabStrip1"
            MultiPageID="RadMultiPageLitography" runat="server" Skin="Windows7" SelectedIndex="0">
            <Tabs>
                <telerik:RadTab Font-Names="Tahoma" Font-Size="11" runat="server" PageViewID="radPlate"
                    Text="پلیت" Selected="True">
                </telerik:RadTab>
                <telerik:RadTab Font-Names="Tahoma" Font-Size="11" runat="server" PageViewID="radFilm"
                    Text="فیلم">
                </telerik:RadTab>
                <telerik:RadTab Font-Names="Tahoma" Font-Size="11" runat="server" PageViewID="radCopyZink"
                    Text="کپی زینک">
                </telerik:RadTab>
                <telerik:RadTab Font-Names="Tahoma" Font-Size="11" runat="server" PageViewID="radStereoType"
                    Text="کلیشه">
                </telerik:RadTab>
                <telerik:RadTab Font-Names="Tahoma" Font-Size="11" runat="server" PageViewID="radRePrint"
                    Text="تجدید چاپ">
                </telerik:RadTab>
            </Tabs>
        </telerik:RadTabStrip>
        <telerik:RadMultiPage ID="RadMultiPageLitography" runat="server" SelectedIndex="0"
            Width="100%">
            <telerik:RadPageView runat="server" ID="radPlate" Selected="True">
                <table style="padding: 10px">
                    <tr>
                        <td>سفارش گیرنده
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPlateOrderReceiver"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPlateOrderReceiver"
                                ValidationGroup="insertPlate" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>ابعاد
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPlateDimension"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPlateDimension"
                                ValidationGroup="insertPlate" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>LPI
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPlateLPI" DataTextField="Name"
                                DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPlateLPI"
                                ValidationGroup="insertPlate" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد رنگ اصلی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPlateMainColorCount"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPlateMainColorCount"
                                ValidationGroup="insertPlate" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>رنگ های خروجی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPlateExportColor"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPlateExportColor"
                                ValidationGroup="insertPlate" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد رنگ های Spot
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPlateSpotColorCount"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPlateSpotColorCount"
                                ValidationGroup="insertPlate" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>نام رنگ های Spot
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Skin="Web20" TextMode="MultiLine" Width="300px"
                                ID="txtPlateSpotColors">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>رنگ مشکی OverPrint
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPlateOverPrintBlackColor"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="دارد" Value="true" />
                                    <telerik:RadComboBoxItem runat="server" Text="ندارد" Value="false" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد دستگاه
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtPlateDeviceCount" MinValue="0" Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد فرم پشت و رو
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtPlateFormEvertCount" MinValue="0"
                                Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>توضیحات
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtPlateDescription"
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
                                            <telerik:RadNumericTextBox runat="server" ID="txtPlateInvoiceRow" MinValue="0" Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>شماره
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtPlateInvoiceNum" MinValue="0" Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>مبلغ
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtPlateInvoiceCost" MinValue="0" Skin="Web20">
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
                            <asp:Button runat="server" ID="btnPlateSave" Text="ثبت" OnClick="btnPlateSave_Click"
                                ValidationGroup="insertPlate" />
                            <asp:Button runat="server" ID="btnPlateEdit" Text="ویرایش" OnClick="btnPlateEdit_Click"
                                ValidationGroup="insertPlate" />
                            <asp:Button runat="server" ID="btnPlateCancel" Text="انصراف" OnClick="btnPlateCancel_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lblPlateMessage"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table style="padding: 10px; width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="grdviewPlate" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                                EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" PageSize="10"
                                Width="100%" OnPageIndexChanging="grdviewPlate_PageIndexChanging" GridLines="None"
                                ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="OrderReceiverName" HeaderText="سفارش گیرنده">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DimensionName" HeaderText="ابعاد">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="LpiName" HeaderText="LPI">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Description" HeaderText="توضیحات">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="LoadPlateEditData" runat="server" OnClick="LoadPlateEditData_Click"
                                                CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/edit.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="PlateDelete" runat="server" OnClick="PlateDelete_Click" OnClientClick="return ConfirmOnDelete();"
                                                CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/delete.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"
                                                NavigateUrl='<%# "PrintPreviewPage.aspx?PlateId=" + Eval("Id") %>'></asp:HyperLink>
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
                        </td>
                    </tr>
                </table>
            </telerik:RadPageView>
            <telerik:RadPageView runat="server" ID="radFilm">
                <table style="padding: 10px">
                    <tr>
                        <td>سفارش گیرنده
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFilmOrderReceiver"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbFilmOrderReceiver"
                                ValidationGroup="insertFilm" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>ابعاد
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Skin="Web20" ID="txtFilmDimension">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>LPI
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFilmLPI" DataTextField="Name"
                                DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbFilmLPI"
                                ValidationGroup="insertFilm" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد رنگ اصلی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFilmMainColorCount"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbFilmMainColorCount"
                                ValidationGroup="insertFilm" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>رنگ های خروجی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFilmExportColor"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbFilmExportColor"
                                ValidationGroup="insertFilm" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد رنگ های Spot
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFilmSpotColorCount"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbFilmSpotColorCount"
                                ValidationGroup="insertFilm" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>نام رنگ های Spot
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Skin="Web20" TextMode="MultiLine" Width="300px"
                                ID="txtFilmSpotColors">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>رنگ مشکی OverPrint
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFilmOverPrintBlackColor"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="دارد" Value="true" />
                                    <telerik:RadComboBoxItem runat="server" Text="ندارد" Value="false" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد دستگاه
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtFilmDeviceCount" MinValue="0" Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد فرم پشت و رو
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtFilmFormEvertCount" MinValue="0"
                                Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>فیلم
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbFilm" DataTextField="Name"
                                DataValueField="Id" Skin="Office2010Blue">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="خوانا" Value="true" />
                                    <telerik:RadComboBoxItem runat="server" Text="ناخوانا" Value="false" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>توضیحات
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtFilmDescription"
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
                                            <telerik:RadNumericTextBox runat="server" ID="txtFilmInvoiceRow" MinValue="0" Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>شماره </td>
                                        <td>
                                            <telerik:RadNumericTextBox ID="txtFilmInvoiceNum" runat="server" MinValue="0" Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>مبلغ
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtFilmInvoiceCost" MinValue="0" Skin="Web20">
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
                            <asp:Button runat="server" ID="btnFilmSave" Text="ثبت" OnClick="btnFilmSave_Click"
                                ValidationGroup="insertFilm" />
                            <asp:Button runat="server" ID="btnFilmEdit" Text="ویرایش" OnClick="btnFilmEdit_Click"
                                ValidationGroup="insertFilm" />
                            <asp:Button runat="server" ID="btnFilmCancel" Text="انصراف" OnClick="btnFilmCancel_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lblFilmMessage"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table style="padding: 10px; width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="grdviewFilm" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                                EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" PageSize="10"
                                Width="100%" OnPageIndexChanging="grdviewFilm_PageIndexChanging" GridLines="None"
                                ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="OrderReceiverName" HeaderText="سفارش گیرنده">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Dimension" HeaderText="ابعاد">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="LpiName" HeaderText="LPI">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Description" HeaderText="توضیحات">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="LoadFilmEditData" runat="server" OnClick="LoadFilmEditData_Click"
                                                CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/edit.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="FilmDelete" runat="server" OnClick="FilmDelete_Click" OnClientClick="return ConfirmOnDelete();"
                                                CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/delete.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"
                                                NavigateUrl='<%# "PrintPreviewPage.aspx?FilmId=" + Eval("Id") %>'></asp:HyperLink>
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
                        </td>
                    </tr>
                </table>
            </telerik:RadPageView>
            <telerik:RadPageView runat="server" ID="radCopyZink">
                <table style="padding: 10px">
                    <tr>
                        <td>سفارش گیرنده
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCopyZinkOrderReceiver"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbCopyZinkOrderReceiver"
                                ValidationGroup="insertCopyZink" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>ابعاد
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCopyZinkDimension"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbCopyZinkDimension"
                                ValidationGroup="insertCopyZink" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>LPI
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCopyZinkLPI" DataTextField="Name"
                                DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbCopyZinkLPI"
                                ValidationGroup="insertCopyZink" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد رنگ اصلی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCopyZinkMainColorCount"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbCopyZinkMainColorCount"
                                ValidationGroup="insertCopyZink" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>رنگ های خروجی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCopyZinkExportColor"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbCopyZinkExportColor"
                                ValidationGroup="insertCopyZink" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد رنگ های Spot
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCopyZinkSpotColorCount"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbCopyZinkSpotColorCount"
                                ValidationGroup="insertCopyZink" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>نام رنگ های Spot
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Skin="Web20" TextMode="MultiLine" Width="300px"
                                ID="txtCopyZinkSpotColors">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>رنگ مشکی OverPrint
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCopyZinkOverPrintBlackColor"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="دارد" Value="true" />
                                    <telerik:RadComboBoxItem runat="server" Text="ندارد" Value="false" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد دستگاه
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtCopyZinkDeviceCount" MinValue="0"
                                Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد فرم پشت و رو
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtCopyZinkFormEvertCount" MinValue="0"
                                Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>توضیحات
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtCopyZinkDescription"
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
                                            <telerik:RadNumericTextBox runat="server" ID="txtCopyZinkInvoiceRow" MinValue="0"
                                                Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>شماره
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtCopyZinkInvoiceNum" MinValue="0"
                                                Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>مبلغ
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtCopyZinkInvoiceCost" MinValue="0"
                                                Skin="Web20">
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
                            <asp:Button runat="server" ID="btnCopyZinkSave" Text="ثبت" OnClick="btnCopyZinkSave_Click"
                                ValidationGroup="insertCopyZink" />
                            <asp:Button runat="server" ID="btnCopyZinkEdit" Text="ویرایش" OnClick="btnCopyZinkEdit_Click"
                                ValidationGroup="insertCopyZink" />
                            <asp:Button runat="server" ID="btnCopyZinkCancel" Text="انصراف" OnClick="btnCopyZinkCancel_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lblCopyZinkMessage"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table style="padding: 10px; width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="grdviewCopyZink" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                                EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" PageSize="10"
                                Width="100%" OnPageIndexChanging="grdviewCopyZink_PageIndexChanging" GridLines="None"
                                ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="OrderReceiverName" HeaderText="سفارش گیرنده">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DimensionName" HeaderText="ابعاد">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="LpiName" HeaderText="LPI">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Description" HeaderText="توضیحات">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="LoadCopyZinkEditData" runat="server" OnClick="LoadCopyZinkEditData_Click"
                                                CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/edit.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="CopyZinkDelete" runat="server" OnClick="CopyZinkDelete_Click"
                                                OnClientClick="return ConfirmOnDelete();" CssClass='<%# Eval("Id").ToString() %>'
                                                ImageUrl="Images/delete.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"
                                                NavigateUrl='<%# "PrintPreviewPage.aspx?CopyZinkId=" + Eval("Id") %>'></asp:HyperLink>
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
                        </td>
                    </tr>
                </table>
            </telerik:RadPageView>
            <telerik:RadPageView runat="server" ID="radStereoType">
                <table style="padding: 10px">
                    <tr>
                        <td>سفارش گیرنده
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbStereotypeOrderReceiver"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbStereotypeOrderReceiver"
                                ValidationGroup="Stereotype" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>ابعاد
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Skin="Web20" ID="txtStereotypeDimension">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ضخامت کلیشه
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbStereotypeThickness"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="1/5 mm" Value="1" />
                                    <telerik:RadComboBoxItem runat="server" Text="3 mm" Value="2" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>نوع کلیشه
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbStereotypeType"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="نر" Value="1" />
                                    <telerik:RadComboBoxItem runat="server" Text="ماده" Value="2" />
                                    <telerik:RadComboBoxItem runat="server" Text="نر و ماده" Value="3" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>کلیشه
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbStereotype" DataTextField="Name"
                                DataValueField="Id" Skin="Office2010Blue">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="خوانا" Value="true" />
                                    <telerik:RadComboBoxItem runat="server" Text="ناخوانا (آئینه)" Value="false" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>نوع استفاده
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbStereotypeUsages"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbStereotypeUsages"
                                ValidationGroup="Stereotype" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد کلیشه
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtStereotypeCount" MinValue="0" Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>توضیحات
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtStereotypeDescription"
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
                                            <telerik:RadNumericTextBox runat="server" ID="txtStereotypeInvoiceRow" MinValue="0"
                                                Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>شماره
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtStereotypeInvoiceNum" MinValue="0"
                                                Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>مبلغ
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtStereotypeInvoiceCost" MinValue="0"
                                                Skin="Web20">
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
                            <asp:Button runat="server" ID="btnStereotypeSave" Text="ثبت" OnClick="btnStereotypeSave_Click"
                                ValidationGroup="insertStereotype" />
                            <asp:Button runat="server" ID="btnStereotypeEdit" Text="ویرایش" OnClick="btnStereotypeEdit_Click"
                                ValidationGroup="insertStereotype" />
                            <asp:Button runat="server" ID="btnStereotypeCancel" Text="انصراف" OnClick="btnStereotypeCancel_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lblStereotypeMessage"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table style="padding: 10px; width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="grdviewStereotype" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                                EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" PageSize="10"
                                Width="100%" OnPageIndexChanging="grdviewStereotype_PageIndexChanging" GridLines="None"
                                ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="OrderReceiverName" HeaderText="سفارش گیرنده">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Dimension" HeaderText="ابعاد">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Type" HeaderText="نوع کلیشه">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Description" HeaderText="توضیحات">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="LoadStereotypeEditData" runat="server" OnClick="LoadStereotypeEditData_Click"
                                                CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/edit.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="StereotypeDelete" runat="server" OnClick="StereotypeDelete_Click"
                                                OnClientClick="return ConfirmOnDelete();" CssClass='<%# Eval("Id").ToString() %>'
                                                ImageUrl="Images/delete.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"
                                                NavigateUrl='<%# "PrintPreviewPage.aspx?StereotypeId=" + Eval("Id") %>'></asp:HyperLink>
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
                        </td>
                    </tr>
                </table>
            </telerik:RadPageView>
            <telerik:RadPageView runat="server" ID="radRePrint">
                <table style="padding: 10px">
                    <tr>
                        <td>توضیحات
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtRePrintDescription"
                                TextMode="MultiLine">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button runat="server" ID="btnRePrintSave" Text="ثبت" OnClick="btnRePrintSave_Click"
                                ValidationGroup="insertRePrint" />
                            <asp:Button runat="server" ID="btnRePrintEdit" Text="ویرایش" OnClick="btnRePrintEdit_Click"
                                ValidationGroup="insertRePrint" />
                            <asp:Button runat="server" ID="btnRePrintCancel" Text="انصراف" OnClick="btnRePrintCancel_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lblRePrintMessage"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table style="padding: 10px; width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="grdviewRePrint" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                                EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" PageSize="10"
                                Width="100%" OnPageIndexChanging="grdviewRePrint_PageIndexChanging" GridLines="None"
                                ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="CreateDatePersian" HeaderText="تاریخ">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Description" HeaderText="توضیحات">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="LoadRePrintEditData" runat="server" OnClick="LoadRePrintEditData_Click"
                                                CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/edit.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="RePrintDelete" runat="server" OnClick="RePrintDelete_Click"
                                                OnClientClick="return ConfirmOnDelete();" CssClass='<%# Eval("Id").ToString() %>'
                                                ImageUrl="Images/delete.png" />
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
                        </td>
                    </tr>
                </table>
            </telerik:RadPageView>
        </telerik:RadMultiPage>
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image4" runat="server" ImageUrl="Images/box_51.png" />
        </div>
        <div style="float: left">
            <asp:Image ID="Image7" runat="server" ImageUrl="Images/box_48.png" />
        </div>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
