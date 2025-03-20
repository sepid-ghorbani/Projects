<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ReportBaseOnOrderReceiverManagement.aspx.cs" Inherits="PrintingProject.ReportBaseOnOrderReceiverManagement" %>





<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=10.2.16.1025, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            گزارش گیری بر پایه اطلاعات سفارش گیرنده ها
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <jq:JQLoader ID="JQLoader1" Theme="Redmond" runat="server">
        </jq:JQLoader>
        <br />
        <div class="boxReport">
            <table>
                <tr>
                    <td>
                        <img class="style1" src="Images/Menu/office_folders.png" />
                    </td>
                    <td>موارد زیر را جهت گزارش گیری انتخاب نمایید:
                    </td>
                </tr>
            </table>
            <table style="width: 100%">
                <tr>
                    <td>نوع فعالیت
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboLevelName" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" AppendDataBoundItems="True"
                            DataSourceID="LevelNameDataSource" DataTextField="Name" AutoPostBack="True" DataValueField="Id" Width="250px"
                            OnSelectedIndexChanged="comboLevelName_SelectedIndexChanged">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="همه موارد" Value="0" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                    <td>نام سفارش گیرنده
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboOrderReceivers" MarkFirstMatch="True" runat="server" Width="250px"
                            Skin="Office2010Blue" DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>
                    </td>

                </tr>
                <tr>
                    <td>وضعیت فاکتور
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboInvoiceStatus" MarkFirstMatch="True" runat="server" Width="250px"
                            Skin="Office2010Blue">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="همه موارد" Value="0" />
                                <telerik:RadComboBoxItem runat="server" Text="دریافت شده" Value="دریافت شده" />
                                <telerik:RadComboBoxItem runat="server" Text="عدم دریافت" Value="عدم دریافت" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                    <td>شماره فاکتور
                    </td>
                    <td>
                        <telerik:RadNumericTextBox runat="server" ID="txtInvoiceNum" MinValue="0" Skin="Web20" Width="250px">
                            <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                        </telerik:RadNumericTextBox>
                    </td>
                </tr>
                <tr>
                    <td>نام سفارش دهنده
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboCustomers" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px"
                            DataTextField="Name" DataValueField="Id" AutoPostBack="True" OnSelectedIndexChanged="comboCustomers_SelectedIndexChanged">
                        </telerik:RadComboBox>
                    </td>
                    <td>نام کار
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboJobName" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px" AllowCustomText="True"
                            DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>
                    </td>

                </tr>
                <tr>
                    <td>شماره دستور کار
                    </td>
                    <td>
                        <telerik:RadNumericTextBox runat="server" ID="txtJobNum" MinValue="0" Skin="Web20" Width="250px">
                            <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                        </telerik:RadNumericTextBox>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>از تاریخ
                    </td>
                    <td>
                        <jq:JQDatePicker ID="dtpFromDate" runat="server" ShowSelectButton="True" Regional="fa"
                            Width="225px" AutoPostBack="True" ButtonImage="Images/x_office_calendar.png">
                        </jq:JQDatePicker>
                    </td>
                    <td>تا تایخ
                    </td>
                    <td>
                        <jq:JQDatePicker ID="dtpToDate" runat="server" ShowSelectButton="True" Regional="fa"
                            Width="225px" AutoPostBack="True" ButtonImage="Images/x_office_calendar.png">
                        </jq:JQDatePicker>
                    </td>
                </tr>
                <tr>
                    <td colspan="3"></td>
                    <td style="float: left">
                        <asp:Button runat="server" CssClass="button" ID="btnCreateReport" Text="ایجاد گزارش"
                            OnClick="btnCreateReport_Click" />
                    </td>
                </tr>
            </table>
        </div>
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
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            مشاهدات گزارش
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <telerik:ReportViewer ID="ReportViewer1" Visible="False" Width="100%" runat="server"
            Height="800px" ProgressText="در حال آماده سازی" ZoomPercent="20"></telerik:ReportViewer>
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image3" runat="server" ImageUrl="Images/box_51.png" />
        </div>
        <div style="float: left">
            <asp:Image ID="Image8" runat="server" ImageUrl="Images/box_48.png" />
        </div>
    </div>
    <asp:ObjectDataSource ID="LevelNameDataSource" runat="server" SelectMethod="GetAll"
        TypeName="PrintingProject.BusinessLayer.LevelsFactory"></asp:ObjectDataSource>
    <br />
    <br />
    <br />
</asp:Content>
