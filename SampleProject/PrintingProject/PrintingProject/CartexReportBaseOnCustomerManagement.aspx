<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CartexReportBaseOnCustomerManagement.aspx.cs" Inherits="PrintingProject.CartexReportBaseOnCustomerManagement" %>
<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=10.2.16.1025, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            گزارش گیری بر پایه اطلاعات سفارش دهنده ها
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
                        <telerik:RadComboBox ID="comboJobName" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px" AllowCustomText="True" AutoPostBack="True"
                            DataTextField="JobName" DataValueField="JobCode"   OnSelectedIndexChanged="comboJobName_SelectedIndexChanged">
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>کد کار
                    </td>
                    <td>
                      <%--  <telerik:RadTextBox runat="server" Skin="Web20" ID="txtJobCode" Width="250px">
                        </telerik:RadTextBox>--%>
                         <telerik:RadComboBox ID="comboJobCode" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px" AllowCustomText="True"
                            DataTextField="JobCode" DataValueField="JobCode">
                        </telerik:RadComboBox>
                      
                    </td>
                    <td>وضعیت فاکتور ورودی
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboInputInvoiceStatus" MarkFirstMatch="True" runat="server" Width="250px"
                            Skin="Office2010Blue">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="همه موارد" Value="" />
                                <telerik:RadComboBoxItem runat="server" Text="دریافت شده" Value="1" />
                                <telerik:RadComboBoxItem runat="server" Text="عدم دریافت" Value="0" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                </tr>
              
                <tr>
                      <td>وضعیت تحویل
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboDeliveryStatus" MarkFirstMatch="True" runat="server" Width="250px"
                            Skin="Office2010Blue">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="همه موارد" Value="" />
                                <telerik:RadComboBoxItem runat="server" Text="تحویل شده" Value="1" />
                                <telerik:RadComboBoxItem runat="server" Text="تحویل نشده" Value="0" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                      <td>وضعیت فاکتور خروجی
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboOutputInvoiceStatus" MarkFirstMatch="True" runat="server" Width="250px"
                            Skin="Office2010Blue">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="همه موارد" Value="" />
                                <telerik:RadComboBoxItem runat="server" Text="صادر شده" Value="1" />
                                <telerik:RadComboBoxItem runat="server" Text="صادر نشده" Value="0" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>شماره فاکتور خروجی</td>
                    <td>
                        <telerik:RadTextBox runat="server" Skin="Web20" ID="txtOutputInvoiceNum" Width="250px">
                        </telerik:RadTextBox>
                    </td>
                    <td></td><td></td>
                </tr>
                <tr>
                    <td>از تاریخ
                    </td>
                    <td>
                        <jq:JQDatePicker ID="dtpFromDate" runat="server" ShowSelectButton="True" Regional="fa" Width="225px"
                            AutoPostBack="True" ButtonImage="Images/x_office_calendar.png">
                        </jq:JQDatePicker>
                    </td>
                    <td>تا تایخ
                    </td>
                    <td>
                        <jq:JQDatePicker ID="dtpToDate" runat="server" ShowSelectButton="True" Regional="fa" Width="225px"
                            AutoPostBack="True" ButtonImage="Images/x_office_calendar.png">
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

    <br />
    <br />
    <br />
</asp:Content>
