<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BackupManagement.aspx.cs" Inherits="PrintingProject.BackupManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            تهیه پشتیبان از پایگاه داده
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        </telerik:RadAjaxManager>
        <table width="100%">
            <tr>
                <td>
                    <img src="Images/zip_file.png" />
                </td>
                <td>
                    <table width="100%">
                       
                        <tr>
                            <td>
                                در صورت تمایل برای تهیه فایل پشتیبان به صورت دستی از این قسمت اقدام نمایید.
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left">
                                <asp:Button ID="btnBackup" runat="server" Text="پشتیبان گیری" CssClass="button" 
                                    onclick="btnBackup_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: left">
                    <asp:Label ID="lblMessageBackup" runat="server"></asp:Label>
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
   <%-- <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image1" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
            بازیابی فایل پشتیبان
        </div>
        <div style="float: left">
            <asp:Image ID="Image2" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <table width="100%">
            <tr>
                <td>
                    <img src="Images/zip_file_search.png" />
                </td>
                <td>
                    <table width="100%">
                        <tr>
                            <td>
                                فایل مورد نظر را انتخاب نمایید:
                            </td>
                            <td>
                                <telerik:RadAsyncUpload ID="RadUpload" runat="server" MaxFileInputsCount="1" EnableInlineProgress="true">
                                    <FileFilters>
                                        <telerik:FileFilter Description="BackUp files(bak)" Extensions="bak" />
                                    </FileFilters>
                                </telerik:RadAsyncUpload>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left" colspan="2">
                                <asp:Button ID="btnRestore" runat="server" Text="بازیابی" CssClass="button" 
                                    onclick="btnRestore_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: left">
                    <asp:Label ID="lblMessageRestore" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <div class="sectionfooter">
        <div style="float: right">
            <asp:Image ID="Image3" runat="server" ImageUrl="Images/box_51.png" /></div>
        <div style="float: left">
            <asp:Image ID="Image8" runat="server" ImageUrl="Images/box_48.png" /></div>
    </div>--%>
</asp:Content>
