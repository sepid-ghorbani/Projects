<%@ Page Title="کنترل فعالیت های کاربران" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="HistoryManagement.aspx.cs" Inherits="PrintingProject.HistoryManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <jq:JQLoader ID="JQLoader1" Theme="Redmond" runat="server">
    </jq:JQLoader>
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            کنترل فعالیت های کاربران
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <table>
            <tr>
                <td>
                    نام کاربر را انتخاب نمایید &nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbUser" Skin="Office2010Blue"
                        DataTextField="Name" DataValueField="Id">
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    از تاریخ
                </td>
                <td>
                    <jq:JQDatePicker ID="dtpFromDate" runat="server" ShowSelectButton="True" Regional="fa"
                        Width="156px" ButtonImage="Images/x_office_calendar.png"></jq:JQDatePicker>
                </td>
            </tr>
            <tr>
                <td>
                    تا تاریخ
                </td>
                <td>
                    <jq:JQDatePicker ID="dtpToDate" runat="server" ShowSelectButton="True" Regional="fa"
                        Width="156px" ButtonImage="Images/x_office_calendar.png"></jq:JQDatePicker>
                </td>
            </tr>
            <tr>
                <td>
                    عبارت جستجو
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtSearch">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnshow" runat="server" Text="مشاهده" CssClass="button" OnClick="btnshow_Click" />
                </td>
            </tr>
        </table>
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
            لیست فعالیت ها
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewHistory" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
            EmptyDataText="رکوردی موجود نیست." CellPadding="4" Width="100%" GridLines="None"
            ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="User" HeaderText="کاربر">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Description" HeaderText="عملکرد">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Date" HeaderText="تاریخ">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Time" HeaderText="ساعت">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
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
            <asp:Image ID="Image3" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image8" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>
</asp:Content>
