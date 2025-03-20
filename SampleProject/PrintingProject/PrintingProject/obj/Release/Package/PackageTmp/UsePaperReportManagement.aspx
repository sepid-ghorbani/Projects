<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UsePaperReportManagement.aspx.cs" Inherits="PrintingProject.UsePaperReportManagement" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=10.2.16.1025, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            گزارش مصرف کاغذ
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

                    <td>سفارش دهنده
                    </td>
                    <td>
                        <telerik:RadComboBox ID="cmbCustomers" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px"
                            DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>
                    </td>


                    <td>مبدا
                    </td>
                    <td>
                        <telerik:RadComboBox ID="cmbSource" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px"
                            DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>
                    </td>

                </tr>
                <tr>
                    <td>نوع جنس مصرفی
                    </td>
                    <td>

                        <telerik:RadComboBox ID="cmbMaterialType" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px"
                            DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>

                    </td>
                    <td>گرماژ جنس مصرفی
                    </td>
                    <td>
                        <telerik:RadComboBox ID="cmbMaterialTypeGramazh" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px"
                            DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>عرض کاغذ
                    </td>
                    <td>

                        <telerik:RadComboBox ID="cmbPaperWidth" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px"
                            DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>

                    </td>
                    <td>طول کاغذ
                    </td>
                    <td>
                        <telerik:RadComboBox ID="cmbPaperHeight" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px"
                            DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>
                    </td>
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
                    <td>وضعیت مصرف
                    </td>
                    <td>
                        <telerik:RadComboBox ID="cmbUseStatus" MarkFirstMatch="True" runat="server" Width="250px"
                            Skin="Office2010Blue">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="همه موارد" Value="" />
                                <telerik:RadComboBoxItem runat="server" Text="مصرف دارد" Value="1" />
                                <telerik:RadComboBoxItem runat="server" Text="مصرف ندارد" Value="0" />
                            </Items>
                        </telerik:RadComboBox>
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
