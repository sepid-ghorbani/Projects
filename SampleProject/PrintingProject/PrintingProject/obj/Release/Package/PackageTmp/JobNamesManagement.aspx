<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="JobNamesManagement.aspx.cs" Inherits="PrintingProject.JobNamesManagement" %>

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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image9" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            خواندن از فایل اکسل
        </div>
        <div style="float: left">
            <asp:Image ID="Image10" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <table width="100%">
            <tr>
                <td>سفارش دهنده
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCustomers" DataTextField="Name" Width="500px"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator ID="RequiredCustomers" runat="server" ErrorMessage="*"
                        ControlToValidate="cmbCustomers" ValidationGroup="insertFile" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>فایل مورد نظر را انتخاب نمایید:
                </td>
                <td>
                    <%--<input type="file" runat="server" name="UploadExcel" id="UploadExcel" accept="application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"/>--%>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFile" runat="server" ErrorMessage="*"
                        ControlToValidate="FileUpload1" ValidationGroup="insertFile" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                </td>

            </tr>
            <tr>
                <td></td>

                <td >
                    <asp:Button ID="btnReadExcel" runat="server" Text="بارگذاری" ValidationGroup="insertFile" CssClass="button" OnClick="btnReadExcel_Click" />

                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="lblFileUploadMessage" runat="server"></asp:Label>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%--ورود دستی--%>
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
                    <img src="Images/menu/Submenu/edit_profile.png" />
                </td>
                <td>
                    <br />
                    اضافه کردن نام کار
                </td>
            </tr>
        </table>
        <table style="padding: 10px">
              <tr>
                <td>سفارش دهنده
                </td>
                <td>
                    <telerik:RadComboBox MarkFirstMatch="True" runat="server" ID="cmbCustomersManual" DataTextField="Name" Width="500px"
                        DataValueField="Id" Skin="Office2010Blue">
                    </telerik:RadComboBox>
                    <asp:RequiredFieldValidator ID="RequiredCustomers2" runat="server" ErrorMessage="*"
                        ControlToValidate="cmbCustomersManual" ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>کد کالا - دستور کار
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtCode" Width="500px">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>نام کالا - دستور کار
                </td>
                <td>
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtName" Width="500px">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredName" runat="server" ErrorMessage="*" ControlToValidate="txtName"
                        ValidationGroup="insert" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>کد کالا - انبار
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtStoreCode" MinValue="0" Skin="Web20" Width="500px">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
            </tr>
              <tr>
                <td>فی 1 - ورودی
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtFee1" MinValue="0" Skin="Web20" Width="500px">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
                </td>
            </tr>
              <tr>
                <td>فی 2 - خروجی
                </td>
                <td>
                    <telerik:RadNumericTextBox runat="server" ID="txtFee2" MinValue="0" Skin="Web20" Width="500px">
                        <NumberFormat AllowRounding="False" GroupSeparator="," ZeroPattern="n" />
                    </telerik:RadNumericTextBox>
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
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/box_32.png" />
        </div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            لیست نام کارها
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewJobNames" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="رکوردی موجود نیست."
            CellPadding="4" AllowPaging="True" PageSize="10" Width="100%"
            OnPageIndexChanging="grdviewJobNames_PageIndexChanging"
            GridLines="None" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                 <asp:BoundField DataField="CustomerName" HeaderText="نام سفارش دهنده">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Code" HeaderText="کد کالا - دستور کار">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="نام کالا - دستور کار">
                    <HeaderStyle HorizontalAlign="Right" />
                    <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="StoreCode" HeaderText="کد کالا - انبار">
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
