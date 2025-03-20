<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ConnectWithUs.aspx.cs" Inherits="PrintingProject.ConnectWithUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .dir_style
        {
            direction: ltr;
        }
        .style1
        {
            width: 103px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sectionheader">
        <div style="float: right">
            <asp:Image ID="Image6" runat="server" ImageUrl="Images/box_32.png" /></div>
        <div style="float: right; padding-top: 5px; height: 14px;">
           ارتباط با ما
        </div>
        <div style="float: left">
            <asp:Image ID="Image5" runat="server" ImageUrl="Images/box_29.png" /></div>
    </div>
    <div class="sectioncontent">
        <table width="100%">
            <tr>
                <td>
                    <img src="Images/Connect/telephone.png" />
                </td>
                <td class="style1">تلفن</td>
                <td>02188918058</td>

            </tr>
            <tr>
                <td>
                    <img src="Images/Connect/full_page.png" />
                </td>
                <td class="style1">فکس</td>
                <td>02188918059</td>
            </tr>
            <tr>
                <td>
                    <img src="Images/Connect/mobile_phone.png" />
                </td>
                <td class="style1">سامانه پیام کوتاه</td>
                <td>30000088</td>
            </tr>
            <tr>
                <td>
                    <img src="Images/Connect/yellow_mail.png" />
                </td>
                <td class="style1">پست الکترونیکی</td>
                <td>Novinideh@yahoo.com</td>
            </tr>
            <tr>
                <td>
                    <img src="Images/Connect/search_map.png" />
                </td>
                <td class="style1">آدرس</td>
                <td>
                    بالاتر از میدان ولیعصر جنب سینما استقلال کوچه فرشید پلاک 28 واحد 11 طبقه سوم
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <img src="Images/map-novinideh.jpg" />
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
</asp:Content>
