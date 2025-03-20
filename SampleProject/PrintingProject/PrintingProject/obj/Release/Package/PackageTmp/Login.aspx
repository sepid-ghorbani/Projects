<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PrintingProject.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ورود به سامانه مدیریت سایت</title>
    <link href="cpanel.css" rel="stylesheet" type="text/css" />
</head>
<body style="background-color: #e8e8e8" class="Loginbody">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="message">
        <asp:Label ID="lblmessage" runat="server"></asp:Label>
    </div>
    <div dir="rtl" style="width: 420px; margin: 0 auto;">
        <table cellpadding="0" cellspacing="0" border="0" width="420px" style="background-color: White;">
            <tr>
                <td colspan="2" class="tdheader">
                    ورود به سامانه مدیریت سایت
                </td>
            </tr>
            <tr>
                <td>
                    <div runat="server" id="divLogin">
                        <table>
                            <tr>
                                <td style="width: 70px; height: 30px; padding-right: 5px;">
                                    <br />
                                    نام کاربری:
                                </td>
                                <td>
                                    <br />
                                    <asp:TextBox ID="txtUserName" Width="280px" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 70px; height: 30px; padding-right: 5px;">
                                    کلمه عبور:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPassword" Width="122px" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:HyperLink ID="hplForgotpassword" runat="server" NavigateUrl="?F=1">کلمه عبورم را فراموش کرده ام!</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>
                                    <telerik:RadCaptcha ID="RadCaptcha1" runat="server" Visible="False" CaptchaTextBoxLabel="عبارت بالا را وارد نمایید.">
                                    </telerik:RadCaptcha>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 70px; height: 30px;">
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:Button ID="btnSignin" runat="server" CssClass="button" Text="ورود به سامانه"
                                        Width="122px" OnClick="btnSignin_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div id="divRecoveryPass" runat="server">
                        <table>
                            <tr>
                                <td style="height: 30px; padding-right: 5px;" colspan="2">
                                    <br />
                                    لطفا پست الکترونیکی خود را جهت بازیابی اطلاعات ورود وارد نمایید:
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 70px; height: 30px; padding-right: 5px;">
                                </td>
                                <td>
                                    <br />
                                    <telerik:RadTextBox ID="txtEmail" Skin="Web20" runat="server" Width="280px" EmptyMessage="YourEmail@domain.com">
                                    </telerik:RadTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 70px; height: 30px;">
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:Button ID="btnSendEmail" runat="server" CssClass="button" Text="بازیابی اطلاعات ورود"
                                        Width="122px" OnClick="btnSendEmail_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 10px;" colspan="2">
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
