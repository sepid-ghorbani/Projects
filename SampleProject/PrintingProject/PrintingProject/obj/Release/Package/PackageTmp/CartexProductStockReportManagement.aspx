<%@ page title="" language="C#" masterpagefile="~/Site.Master" autoeventwireup="true"
    codebehind="CartexProductStockReportManagement.aspx.cs" inherits="PrintingProject.CartexProductStockReportManagement" %>





<%@ register assembly="Telerik.ReportViewer.WebForms, Version=10.2.16.1025, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder2" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            گزارش گیری موجودی کارتکس محصول
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
                        نام سفارش گیرنده
                    </td>
                    <td>
                         <telerik:RadComboBox ID="comboOrderReceivers" MarkFirstMatch="True" runat="server" Width="250px"
                            Skin="Office2010Blue" DataTextField="Name" DataValueField="Id">
                        </telerik:RadComboBox>
                    </td>
                     <td>نوع کار
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboJobType" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px"
                            DataTextField="Name" DataValueField="Id" AutoPostBack="True" >
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                      <td>نام کار
                    </td>
                    <td>
                        <telerik:RadComboBox ID="comboJobName" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px" AllowCustomText="True" AutoPostBack="True"
                            DataTextField="JobName" DataValueField="JobCode" OnSelectedIndexChanged="comboJobName_SelectedIndexChanged">
                        </telerik:RadComboBox>
                    </td>
                     <td>کد کار
                    </td>
                    <td>
                        <%-- <telerik:RadTextBox runat="server" Skin="Web20" ID="txtJobCode" Width="250px">
                        </telerik:RadTextBox>--%>
                         <telerik:RadComboBox ID="comboJobCode" MarkFirstMatch="True" runat="server" Skin="Office2010Blue" Width="250px" AllowCustomText="True"
                            DataTextField="JobCode" DataValueField="JobCode">
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td></td>
                    <td></td>
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

    <br />
    <br />
    <br />
</asp:content>
