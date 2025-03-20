<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="FinalInvoiceManagement.aspx.cs" Inherits="PrintingProject.FinalInvoiceManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            فاکتور نهایی
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
                        <asp:HyperLink ID="HyperLinkLetterPress" runat="server">دایکات</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkMakingTemplate" runat="server">قالب</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkSahafi" runat="server">صحافی</asp:HyperLink>
                    </td>
                    <td style="width: 100px;">
                        <asp:HyperLink ID="HyperLinkFinalInvoice" runat="server" BackColor="#99CCFF">فاکتور</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
        <table align="center">
            <tr>
                <td>
                    <div class="box" style="width: 350px;">
                        <table width="100%" cellspacing="0">
                            <tr>
                                <td colspan="2">
                                    <asp:CheckBox ID="chkHasntFactor" runat="server" Text="فاکتور ندارد" AutoPostBack="True"
                                        OnCheckedChanged="chkHasntFactor_CheckedChanged" />
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr style="background-color: whitesmoke;">
                                <td>
                                    پلیت
                                </td>
                                <td>
                                    <asp:Label ID="lblPlateCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtPlateCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtPlateCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtPlateCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    فیلم
                                </td>
                                <td>
                                    <asp:Label ID="lblFilmCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtFilmCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtFilmCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtFilmCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr style="background-color: whitesmoke">
                                <td>
                                    کپی زینک
                                </td>
                                <td>
                                    <asp:Label ID="lblCopyZink" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtCopyZinkCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtCopyZinkCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtCopyZinkCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    کلیشه
                                </td>
                                <td>
                                    <asp:Label ID="lblStereotypeCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtStereotypeCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtStereotypeCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtStereotypeCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr style="background-color: whitesmoke">
                                <td>
                                    چاپ
                                </td>
                                <td>
                                    <asp:Label ID="lblPrintingCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtPrintingCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtPrintingCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtPrintingCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    خرید کاغذ
                                </td>
                                <td>
                                    <asp:Label ID="lblBuyPaperCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtBuyPaperCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtBuyPaperCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtBuyPaperCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr style="background-color: whitesmoke">
                                <td>
                                    روکش
                                </td>
                                <td>
                                    <asp:Label ID="lblVeneerCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtVeneerCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtVeneerCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtVeneerCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    دایکات
                                </td>
                                <td>
                                    <asp:Label ID="lblLetterPressCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtLetterPressCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtLetterPressCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtLetterPressCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr style="background-color: whitesmoke">
                                <td>
                                    ساخت قالب
                                </td>
                                <td>
                                    <asp:Label ID="lblMakingTemplateCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtMakingTemplateCost" MinValue="0"
                                        AutoPostBack="True" Skin="Web20" OnTextChanged="txtMakingTemplateCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtMakingTemplateCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    صحافی
                                </td>
                                <td>
                                    <asp:Label ID="lblSahafiCost" runat="server"></asp:Label>
                                </td>
                                <td style="float: left">
                                    <telerik:RadNumericTextBox runat="server" ID="txtSahafiCost" MinValue="0" AutoPostBack="True"
                                        Skin="Web20" OnTextChanged="txtSahafiCost_TextChanged">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator runat="server" ErrorMessage="*" ControlToValidate="txtSahafiCost"
                                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr style="background-color: whitesmoke">
                                <td>
                                    مجموع
                                </td>
                                <td>
                                    <asp:Label ID="lblSumInputCosts" runat="server"></asp:Label>
                                </td>
                                <td style="float: left; height: 20px; padding-left: 12px;">
                                    <asp:Label ID="lblSumOutputCosts" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td style="float: left; height: 20px;">
                                    <telerik:RadNumericTextBox runat="server" ID="txtSumOutputCosts" MinValue="0" Skin="Web20">
                                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                                    </telerik:RadNumericTextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                        ControlToValidate="txtSumOutputCosts" ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr style="background-color: whitesmoke">
                                <td>
                                    توضیحات
                                </td>
                                <td>
                                </td>
                                <td style="height: 50px; float: left; padding-top: 5px; padding-left: 12px;">
                                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtDescription" TextMode="MultiLine">
                                    </telerik:RadTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                </td>
                                <td style="float: left">
                                    <br/>
                                    <table>
                                        <tr>
                                            <td>
                                    <asp:HyperLink ImageUrl="Images/printer.png" ID="HyperLink1" runat="server" Target="_blank"></asp:HyperLink>
                                                
                                            </td>
                                            <td>
                                                    <asp:Button runat="server" ID="btnSave" Text="ثبت فاکتور" OnClick="btnSave_Click"
                                        ValidationGroup="insert" Style="text-align: center" /> &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                </td>
                                <td style="float: left">
                                    <asp:Label runat="server" ID="lblMessage"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image4" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image7" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>
</asp:Content>
