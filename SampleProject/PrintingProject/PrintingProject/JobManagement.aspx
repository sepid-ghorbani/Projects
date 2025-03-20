<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="JobManagement.aspx.cs" Inherits="PrintingProject.JobManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" language="javascript">
        function ConfirmOnDelete() {
            if (confirm("آیا از حذف این سطر اطمینان دارید؟") == true)
                return true;
            else
                return false;
        }

        function ConfirmOnCopy() {
            if (confirm("آیا از کپی این دستورکار اطمینان دارید؟") == true)
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
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <table>
            <tr>
                <td>
                    <img src="Images/menu/Submenu/user_comment.png" />
                </td>
                <td>
                    <br />
                    اضافه کردن دستور کار جدید
                </td>
            </tr>
        </table>
        <table style="padding: 10px">
            <tr>
                <td>سفارش دهنده
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCustomers" DataTextField="Name" Width="500px"
                        DataValueField="Id" Skin="Office2010Blue" AutoPostBack="True" OnSelectedIndexChanged="cmbCustomers_SelectedIndexChanged">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator ID="RequiredCustomers" runat="server" ErrorMessage="*"
                        ControlToValidate="cmbCustomers" ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>نام کار
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbJobName" DataTextField="Name" Width="500px" DataValueField="StoreCode"
                        AllowCustomText="True" Skin="Office2010Blue" AutoPostBack="True" OnSelectedIndexChanged="cmbJobName_SelectedIndexChanged">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator ID="RequiredName" runat="server" ErrorMessage="*" ControlToValidate="cmbJobName"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>کد کار
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtCode" Width="500px">
                    </telerik:RadTextBox>
                    <asp:Label ID="lblStoreCode" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>توضیحات
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Width="500px" Height="50px" Skin="Web20" ID="txtDescription"
                        TextMode="MultiLine">
                    </telerik:RadTextBox>
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
            <asp:Image ID="Image9" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            جستجو
        </div>
        <div style="float: left">
            <asp:Image ID="Image10" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <table style="padding: 10px">
            <tr>
                <td>شماره دستور کار &nbsp;
                    <telerik:RadNumericTextBox runat="server" ID="txtSearchId" MinValue="0" Skin="Web20">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
                <td>&nbsp;نام کار &nbsp;
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtSearchName">
                    </telerik:RadTextBox>
                </td>
                <td>&nbsp;کد کار &nbsp;
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtSearchCode">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:Button runat="server" ID="btnSearch" Text="جستجو" OnClick="btnSearch_Click" />
                </td>


            </tr>
        </table>
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image11" runat="server" ImageUrl="Images/box_51.png" />
        </div>
        <div style="float: left">
            <asp:Image ID="Image12" runat="server" ImageUrl="Images/box_48.png" />
        </div>
    </div>
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            لیست دستور کارها
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewJobs" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
            EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" Width="100%"
            GridLines="None" ForeColor="#333333" DataSourceID="JobsDataSource" PageSize="20">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="شماره دستور کار">
                    <HeaderStyle HorizontalAlign="Right" Width="70px" />
                    <ItemStyle HorizontalAlign="Right" Width="70px" />
                </asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="نام کار">
                    <HeaderStyle HorizontalAlign="Right" Width="180px" />
                    <ItemStyle HorizontalAlign="Right" Width="180px" />
                </asp:BoundField>
                <asp:BoundField DataField="CreateDatePersian" HeaderText="تاریخ ایجاد">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="LoadEditData" runat="server" OnClick="LoadEditData_Click" CssClass='<%# Eval("Id").ToString() %>'
                            ImageUrl="Images/edit.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <%--<asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="Delete" runat="server" OnClick="Delete_Click" OnClientClick="return ConfirmOnDelete();"
                            CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/delete.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>--%>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="JobCopy" runat="server" CssClass='<%# Eval("Id").ToString() %>' OnClientClick="return ConfirmOnCopy();"
                            ToolTip="کپی" OnClick="JobCopy_Click" ImageUrl="Images/Menu/JobMenu/copy_paste.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# "LitographyManagement.aspx?JId=" + Eval("Id").ToString() + "&Index=0" %>' title="لیتوگرافی" target="_blank">
                            <img src="Images/Menu/JobMenu/litography.png" />
                        </a>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# "PrintingManagement.aspx?JId=" + Eval("Id").ToString() + "&Index=0" %>' title="چاپ" target="_blank">
                            <img src="Images/Menu/JobMenu/print.png" />
                        </a>
                        <%-- <asp:ImageButton ID="Print" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="چاپ" OnClick="Printing_Click" ImageUrl="Images/Menu/JobMenu/print.png" />--%>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# "PaperManagement.aspx?JId=" + Eval("Id").ToString() + "&Index=0" %>' title="کاغذ" target="_blank">
                            <img src="Images/Menu/JobMenu/paper.png" />
                        </a>
                        <%--  <asp:ImageButton ID="Paper" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="کاغذ" OnClick="Paper_Click" ImageUrl="Images/Menu/JobMenu/paper.png" />--%>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# "VeneerManagement.aspx?JId=" + Eval("Id").ToString() + "&Index=0" %>' title="روکش" target="_blank">
                            <img src="Images/Menu/JobMenu/veneer.png" />
                        </a>
                        <%-- <asp:ImageButton ID="Veneer" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="روکش" OnClick="Veneer_Click" ImageUrl="Images/Menu/JobMenu/veneer.png" />--%>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# "LetterPressManagement.aspx?JId=" + Eval("Id").ToString() + "&Index=0" %>' title="دایکات" target="_blank">
                            <img src="Images/Menu/JobMenu/letterPress.png" />
                        </a>
                        <%-- <asp:ImageButton ID="LetterPress" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="دایکات" OnClick="LetterPress_Click" ImageUrl="Images/Menu/JobMenu/letterPress.png" />--%>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# "MakingTemplateManagement.aspx?JId=" + Eval("Id").ToString() + "&Index=0" %>' title="قالب" target="_blank">
                            <img src="Images/Menu/JobMenu/template.png" />
                        </a>
                        <%--  <asp:ImageButton ID="Template" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="قالب" OnClick="MakingTemplate_Click" ImageUrl="Images/Menu/JobMenu/template.png" />--%>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# "SahafiManagement.aspx?JId=" + Eval("Id").ToString() + "&Index=0" %>' title="صحافی" target="_blank">
                            <img src="Images/Menu/JobMenu/sahafi.png" />
                        </a>
                        <%--    <asp:ImageButton ID="Sahafi" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="صحافی" OnClick="Sahafi_Click" ImageUrl="Images/Menu/JobMenu/sahafi.png" />--%>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# "FinalInvoiceManagement.aspx?JId=" + Eval("Id").ToString() + "&Index=0" %>' title="فاکتور نهایی" target="_blank">
                            <img src="Images/Menu/JobMenu/finalinvoice.png" />
                        </a>
                        <%--   <asp:ImageButton ID="FinalInvoice" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="فاکتور نهایی" OnClick="FinalInvoice_Click" ImageUrl="Images/Menu/JobMenu/finalinvoice.png" />--%>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
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
        <asp:ObjectDataSource ID="JobsDataSource" SelectCountMethod="GetTotalCount" SelectMethod="GetDataList"
            MaximumRowsParameterName="pageSize" TypeName="PrintingProject.JobManagement"
            StartRowIndexParameterName="startIndex" EnablePaging="True" runat="server">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtSearchId" Name="searchId" PropertyName="Text"
                    Type="Int32" DefaultValue="" />
                <asp:ControlParameter ControlID="txtSearchName" Name="searchName" PropertyName="Text"
                    Type="String" DefaultValue="" />
                <asp:ControlParameter ControlID="txtSearchCode" Name="searchCode" PropertyName="Text"
                    Type="String" DefaultValue="" />
            </SelectParameters>
        </asp:ObjectDataSource>
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
