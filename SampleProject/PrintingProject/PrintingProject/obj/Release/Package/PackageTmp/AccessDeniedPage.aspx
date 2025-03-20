<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccessDeniedPage.aspx.cs"
    Inherits="PrintingProject.AccessDeniedPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       
        .centered
        {
            position: fixed;
            z-index: 100;
            top: 50%;
            left: 33%;
            margin: -100px 0 0 -100px;
            width: 500px;
            height: 150px;
            border: 1px solid #800000;
            background: #FFE6E6;
            border-style: solid;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="centered" >
        <table dir="rtl" align="center" >
            <tr>
                <td>
                    <img src="Images/delete_page.png" />
                </td>
                <td style="font-family: Tahoma; font-size: small; font-weight: bold ">
                    کاربر گرامی شما اجازه دسترسی به این صفحه را ندارید.
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
