<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="StockReportManagement.aspx.cs" Inherits="PrintingProject.StockReportManagement" %>





<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=10.2.16.1025, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            گزارش گیری موجودی بنگاه ها
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" /></div>
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
                    <td>
                        بنگاه مورد نظر را جهت گزارش گیری انتخاب نمایید:
                    </td>
                </tr>
            </table>
            <table style="width: 100%">
                <tr>
                    <td>
                        نام بنگاه
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboInstitute" MarkFirstMatch="True" runat="server" Skin="Office2010Blue"
                            DataSourceID="InstituteDataSource" DataTextField="Name" 
                            DataValueField="Id" AppendDataBoundItems="True" Width="200px">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="همه موارد" Value="0" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
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
            <asp:Image ID="Image4" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image7" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            مشاهدات گزارش
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <telerik:ReportViewer ID="ReportViewer1" Visible="False" Width="100%" runat="server"
            Height="800px" ProgressText="در حال آماده سازی" ZoomPercent="20"></telerik:ReportViewer>
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image3" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image8" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>
    <asp:ObjectDataSource ID="InstituteDataSource" runat="server" SelectMethod="GetAll"
        TypeName="PrintingProject.BusinessLayer.InstituteFactory"></asp:ObjectDataSource>
    <br />
    <br />
    <br />
</asp:Content>
