<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="PaperManagement.aspx.cs" Inherits="PrintingProject.PaperManagement" %>

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
            سفارش کاغذ
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
                        <asp:HyperLink ID="HyperLinkPrinting" runat="server">چاپ</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkPaper" runat="server" BackColor="#99CCFF">کاغذ</asp:HyperLink>
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
            MultiPageID="RadMultiPagePaper" runat="server" Skin="Windows7" SelectedIndex="1">
            <Tabs>
                <telerik:RadTab Font-Names="Tahoma" Font-Size="11" runat="server" PageViewID="radBuyPaper" Text="خرید کاغذ" Selected="True">
                </telerik:RadTab>
                <telerik:RadTab Font-Names="Tahoma" Font-Size="11" runat="server" PageViewID="radPreparingPaper"
                    Text="تامین کاغذ" >
                </telerik:RadTab>
                <telerik:RadTab Font-Names="Tahoma" Font-Size="11" runat="server" PageViewID="radUsePaper"
                    Text="مصرف کاغذ">
                </telerik:RadTab>
            </Tabs>
        </telerik:RadTabStrip>
        <telerik:RadMultiPage ID="RadMultiPagePaper" runat="server" SelectedIndex="0" Width="100%">
            <telerik:RadPageView runat="server" ID="radBuyPaper" Selected="True" >
                <table style="padding: 10px">
                    <tr>
                        <td>سفارش گیرنده
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbBuyPaperOrderReceiver"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbBuyPaperOrderReceiver"
                                ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>نوع جنس مصرفی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbBuyPaperMaterialType"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbBuyPaperMaterialType"
                                ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>گرماژ جنس مصرفی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbBuyPaperMaterialTypeGramazh"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue" OnSelectedIndexChanged="cmbBuyPaperMaterialTypeGramazh_SelectedIndexChanged"
                                AutoPostBack="True">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbBuyPaperMaterialTypeGramazh"
                                ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>عرض کاغذ
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbBuyPaperPaperWidth"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue" OnSelectedIndexChanged="cmbBuyPaperPaperWidth_SelectedIndexChanged"
                                AutoPostBack="True">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbBuyPaperPaperWidth"
                                ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>طول کاغذ
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbBuyPaperPaperHeight"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue" OnSelectedIndexChanged="cmbBuyPaperPaperHeight_SelectedIndexChanged"
                                AutoPostBack="True">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbBuyPaperPaperHeight"
                                ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد بند
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtBuyPaperParagraphCount" MinValue="0"
                                Skin="Web20" OnTextChanged="txtBuyPaperParagraphCount_TextChanged" AutoPostBack="True">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد برگ
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbBuyPaperLeafCount"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue" OnSelectedIndexChanged="cmbBuyPaperLeafCount_SelectedIndexChanged"
                                AutoPostBack="True">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbBuyPaperLeafCount"
                                ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>فی
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtBuyPaperFee" MinValue="0" Skin="Web20"
                                OnTextChanged="txtBuyPaperFee_TextChanged" AutoPostBack="True">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>جمع مبلغ
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbBuyPaperSumCost"
                                AutoPostBack="True" Skin="Office2010Blue" OnSelectedIndexChanged="cmbBuyPaperSumCost_SelectedIndexChanged">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="کاغذ های کیلویی" Value="1" />
                                    <telerik:RadComboBoxItem runat="server" Text="بندی بسته ای" Value="2" />
                                    <telerik:RadComboBoxItem runat="server" Text="برگی" Value="3" />
                                </Items>
                            </telerik:RadComboBox>
                            &nbsp;&nbsp;
                            <asp:Label ID="lblBuyPaperSumCost" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>محل تخلیه
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbBuyPaperInstitute"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbBuyPaperInstitute"
                                ValidationGroup="insertBuyPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>توضیحات
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtBuyPaperDescription"
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
                                            <telerik:RadNumericTextBox runat="server" ID="txtBuyPaperInvoiceRow" MinValue="0"
                                                Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>شماره
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtBuyPaperInvoiceNum" MinValue="0"
                                                Skin="Web20">
                                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                            </telerik:RadNumericTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>مبلغ
                                        </td>
                                        <td>
                                            <telerik:RadNumericTextBox runat="server" ID="txtBuyPaperInvoiceCost" MinValue="0"
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
                            <asp:Button runat="server" ID="btnBuyPaperSave" Text="ثبت" OnClick="btnBuyPaperSave_Click"
                                ValidationGroup="insertBuyPaper" />
                            <asp:Button runat="server" ID="btnBuyPaperEdit" Text="ویرایش" OnClick="btnBuyPaperEdit_Click"
                                ValidationGroup="insertBuyPaper" />
                            <asp:Button runat="server" ID="btnBuyPaperCancel" Text="انصراف" OnClick="btnBuyPaperCancel_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lblBuyPaperMessage"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table style="padding: 10px; width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="grdviewBuyPaper" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                                EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" PageSize="10"
                                Width="100%" OnPageIndexChanging="grdviewBuyPaper_PageIndexChanging" GridLines="None"
                                ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="PaperSeries" HeaderText="سری خرید">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="OrderReceiverName" HeaderText="سفارش گیرنده">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="MaterialTypeName" HeaderText="نوع جنس مصرفی">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="جمع مبلغ">
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%#  string.Format("{0:#,###0}",Eval("SumCost")) %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="InstituteName" HeaderText="محل تخلیه">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="LoadBuyPaperEditData" runat="server" OnClick="LoadBuyPaperEditData_Click"
                                                CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/edit.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="BuyPaperDelete" runat="server" OnClick="BuyPaperDelete_Click"
                                                OnClientClick="return ConfirmOnDelete();" CssClass='<%# Eval("Id").ToString() %>'
                                                ImageUrl="Images/delete.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"
                                                NavigateUrl='<%# "PrintPreviewPage.aspx?BuyPaperId=" + Eval("Id") %>'></asp:HyperLink>
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
            <telerik:RadPageView runat="server" ID="radPreparingPaper" >
                <table style="padding: 10px">
                    <tr>
                        <td>مبدا
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPreparingPaperFromInstitute"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPreparingPaperFromInstitute"
                                ValidationGroup="insertPreparingPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>مقصد
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPreparingPaperToInstitute"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPreparingPaperToInstitute"
                                ValidationGroup="insertPreparingPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>نوع جنس مصرفی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPreparingPaperMaterialType"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPreparingPaperMaterialType"
                                ValidationGroup="insertPreparingPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>گرماژ جنس مصرفی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPreparingPaperMaterialTypeGramazh"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPreparingPaperMaterialTypeGramazh"
                                ValidationGroup="insertPreparingPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>عرض کاغذ
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPreparingPaperPaperWidth"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPreparingPaperPaperWidth"
                                ValidationGroup="insertPreparingPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>طول کاغذ
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbPreparingPaperPaperHeight"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbPreparingPaperPaperHeight"
                                ValidationGroup="insertPreparingPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد برگ
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtPreparingPaperLeafCount" MinValue="0"
                                Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtPreparingPaperLeafCount"
                                ValidationGroup="insertPreparingPaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>توضیحات
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtPreparingPaperDescription"
                                TextMode="MultiLine">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button runat="server" ID="btnPreparingPaperSave" Text="ثبت" OnClick="btnPreparingPaperSave_Click"
                                ValidationGroup="insertPreparingPaper" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lblPreparingPaperMessage"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table style="padding: 10px; width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="grdviewPreparingPaper" runat="server" AutoGenerateColumns="False"
                                ShowHeaderWhenEmpty="True" EmptyDataText="رکوردی موجود نیست." CellPadding="4"
                                AllowPaging="True" PageSize="10" Width="100%" OnPageIndexChanging="grdviewPreparingPaper_PageIndexChanging"
                                GridLines="None" ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="FromInstituteName" HeaderText="مبدا">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="ToInstituteName" HeaderText="مقصد">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="MaterialTypeName" HeaderText="نوع جنس مصرفی">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="LeafCount" HeaderText="تعداد برگ">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="PreparingPaperDelete" runat="server" OnClick="PreparingPaperDelete_Click"
                                                OnClientClick="return ConfirmOnDelete();" CssClass='<%# Eval("Id").ToString() %>'
                                                ImageUrl="Images/delete.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"
                                                NavigateUrl='<%# "PrintPreviewPage.aspx?PreparingPaperId=" + Eval("Id") %>'></asp:HyperLink>
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
            <telerik:RadPageView runat="server" ID="radUsePaper" >
                <table style="padding: 10px">
                    <tr>
                        <td>مبدا
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbUsePaperFromInstitute"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbUsePaperFromInstitute"
                                ValidationGroup="insertUsePaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>نوع جنس مصرفی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbUsePaperMaterialType"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbUsePaperMaterialType"
                                ValidationGroup="insertUsePaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>گرماژ جنس مصرفی
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbUsePaperMaterialTypeGramazh"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbUsePaperMaterialTypeGramazh"
                                ValidationGroup="insertUsePaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>عرض کاغذ
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbUsePaperPaperWidth"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbUsePaperPaperWidth"
                                ValidationGroup="insertUsePaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>طول کاغذ
                        </td>
                        <td>
                            <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbUsePaperPaperHeight"
                                DataTextField="Name" DataValueField="Id" Skin="Office2010Blue">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="cmbUsePaperPaperHeight"
                                ValidationGroup="insertUsePaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>تعداد برگ
                        </td>
                        <td>
                            <telerik:RadNumericTextBox runat="server" ID="txtUsePaperLeafCount" MinValue="0"
                                Skin="Web20">
                                <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                            </telerik:RadNumericTextBox>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtUsePaperLeafCount"
                                ValidationGroup="insertUsePaper" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>توضیحات
                        </td>
                        <td>
                            <telerik:RadTextBox runat="server" Width="300px" Skin="Web20" ID="txtUsePaperDescription"
                                TextMode="MultiLine">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button runat="server" ID="btnUsePaperSave" Text="ثبت" OnClick="btnUsePaperSave_Click"
                                ValidationGroup="insertUsePaper" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label runat="server" ID="lblUsePaperMessage"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table style="padding: 10px; width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="grdviewUsePaper" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
                                EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" PageSize="10"
                                Width="100%" OnPageIndexChanging="grdviewUsePaper_PageIndexChanging" GridLines="None"
                                ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="FromInstituteName" HeaderText="بنگاه">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="MaterialTypeName" HeaderText="نوع جنس مصرفی">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="LeafCount" HeaderText="تعداد برگ">
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="UsePaperDelete" runat="server" OnClick="UsePaperDelete_Click"
                                                OnClientClick="return ConfirmOnDelete();" CssClass='<%# Eval("Id").ToString() %>'
                                                ImageUrl="Images/delete.png" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"
                                                NavigateUrl='<%# "PrintPreviewPage.aspx?UsePaperId=" + Eval("Id") %>'></asp:HyperLink>
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
