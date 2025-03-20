<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CartexManagement.aspx.cs" Inherits="PrintingProject.CartexManagement" %>

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
                    اضافه کردن کارتکس جدید
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
                <td>&nbsp;نام کار &nbsp;
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtSearchJobName">
                    </telerik:RadTextBox>
                </td>
                <td>&nbsp;کد کار &nbsp;
                    <telerik:RadTextBox runat="server" Skin="Web20" ID="txtSearchJobCode">
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
            لیست کارتکس ها
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" />
        </div>
    </div>
    <div class="sectioncontent">
        <asp:GridView ID="grdviewCartex" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
            EmptyDataText="رکوردی موجود نیست." CellPadding="4" AllowPaging="True" Width="100%"
            GridLines="None" ForeColor="#333333" DataSourceID="CartexesDataSource" PageSize="20">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="JobCode" HeaderText="کد کار">
                    <HeaderStyle HorizontalAlign="Right" Width="180px" />
                    <ItemStyle HorizontalAlign="Right" Width="180px" />
                </asp:BoundField>
                <asp:BoundField DataField="JobName" HeaderText="نام کار">
                    <HeaderStyle HorizontalAlign="Right" Width="180px" />
                    <ItemStyle HorizontalAlign="Right" Width="180px" />
                </asp:BoundField>
                <asp:BoundField DataField="Remain" HeaderText="مانده">
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
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="Delete" runat="server" OnClick="Delete_Click" OnClientClick="return ConfirmOnDelete();"
                            CssClass='<%# Eval("Id").ToString() %>' ImageUrl="Images/delete.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
               
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="PrimaryStock" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="موجودی اولیه" OnClick="PrimaryStock_Click" ImageUrl="Images/Menu/JobMenu/litography.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ProductionOrder" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="سفارش تولید" OnClick="ProductionOrder_Click" ImageUrl="Images/Menu/JobMenu/print.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ProductDelivery" runat="server" CssClass='<%# Eval("Id").ToString() %>'
                            ToolTip="تحویل محصول" OnClick="ProductDelivery_Click" ImageUrl="Images/Menu/JobMenu/paper.png" />
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
        <asp:ObjectDataSource ID="CartexesDataSource" SelectCountMethod="GetTotalCount" SelectMethod="GetDataList"
            MaximumRowsParameterName="pageSize" TypeName="PrintingProject.CartexManagement"
            StartRowIndexParameterName="startIndex" EnablePaging="True" runat="server">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtSearchJobName" Name="searchJobName" PropertyName="Text"
                    Type="String" DefaultValue="" />
                <asp:ControlParameter ControlID="txtSearchJobCode" Name="searchJobCode" PropertyName="Text"
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
