<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="TemplateMaterialTypesManagement.aspx.cs" Inherits="PrintingProject.TemplateMaterialTypesManagement" %>

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
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <table>
            <tr>
                <td>
                    <img src="Images/menu/Submenu/accept_page.png" />
                </td>
                <td>
                    <br />
                    اضافه کردن نوع جنس مصرفی قالب
                </td>
            </tr>
        </table>
        <table style="padding: 10px">
            <tr>
                <td>
                    نام
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtName">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredName" runat="server" ErrorMessage="*" ControlToValidate="txtName"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                </td>
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
            <asp:Image ID="Image4" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image7" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            لیست انواع جنس مصرفی قالب
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewTemplateMaterialTypes" runat="server" AutoGenerateColumns="False"  ShowHeaderWhenEmpty="True" EmptyDataText="رکوردی موجود نیست."
            CellPadding="4" AllowPaging="True" PageSize="10" Width="100%" 
            onpageindexchanging="grdviewTemplateMaterialTypes_PageIndexChanging" 
            GridLines="None" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="نام">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="LoadEditData" runat="server" OnClick="LoadEditData_Click" CssClass='<%# Eval("Id").ToString() %>'
                            ImageUrl="Images/edit.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="Delete" runat="server" OnClick="Delete_Click" OnClientClick="return ConfirmOnDelete();"
                            CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/delete.png" />
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
</asp:Content>
