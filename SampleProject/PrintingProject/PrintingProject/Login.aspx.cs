using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using Microsoft.Win32;
using PrintingProject.BusinessLayer;
namespace PrintingProject
{
    public partial class Login : System.Web.UI.Page
    {
        public int WrongLogin { get { if (ViewState["WrongLogin"] == null) ViewState["WrongLogin"] = 0; return (int)ViewState["WrongLogin"]; } set { ViewState["WrongLogin"] = value; } }
        Users _users = new Users();
        UsersFactory _usersFactory = new UsersFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["F"] != null)
                {
                    divRecoveryPass.Visible = true;
                    divLogin.Visible = false;
                }
                else
                {
                    divRecoveryPass.Visible = false;
                    divLogin.Visible = true;
                }

            }
        }


        protected void btnSignin_Click(object sender, EventArgs e)
        {
            if (WrongLogin > 0)
            {
                var u = _usersFactory.GetAllBy(Users.UsersFields.UserName, txtUserName.Text);
                if (u.Count > 0)
                {
                    if (txtPassword.Text == u[0].Password)
                    {
                        if (u[0].Enable == true)
                        {
                            PrintingProject.Session.IsLogin = true;
                            PrintingProject.Session.UserId = u[0].Id;
                            //history
                            var logInOutHistory = new LogInOutHistories();
                            var logInOutHistoryFactory = new LogInOutHistoriesFactory();

                            logInOutHistory.Date = DateTime.Now;
                            logInOutHistory.Type = true;
                            logInOutHistory.UserId = u[0].Id;
                            logInOutHistoryFactory.Insert(logInOutHistory);

                            Response.Redirect("Default.aspx");
                        }
                        else
                        {
                            lblmessage.Visible = true;
                            lblmessage.ForeColor = System.Drawing.Color.Red;
                            lblmessage.Text = "نام کاربری شما غیر فعال می باشد.";
                        }
                    }
                    else
                    {
                        WrongLogin++;
                        lblmessage.Visible = true;
                        lblmessage.ForeColor = System.Drawing.Color.Red;
                        lblmessage.Text = "نام کاربری یا کلمه عبور اشتباه است.";
                    }
                }
                else
                {
                    WrongLogin++;
                    lblmessage.Visible = true;
                    lblmessage.ForeColor = System.Drawing.Color.Red;
                    lblmessage.Text = "نام کاربری یا کلمه عبور اشتباه است.";
                }

            }
            else
            {
                var u = _usersFactory.GetAllBy(Users.UsersFields.UserName, txtUserName.Text);
                if (u.Count > 0)
                {
                    if (txtPassword.Text == u[0].Password)
                    {
                        if (u[0].Enable)
                        {
                            PrintingProject.Session.IsLogin = true;
                            PrintingProject.Session.UserId = u[0].Id;
                            //history
                            var logInOutHistory = new LogInOutHistories();
                            var logInOutHistoryFactory = new LogInOutHistoriesFactory();

                            logInOutHistory.Date = DateTime.Now;
                            logInOutHistory.Type = true;
                            logInOutHistory.UserId = u[0].Id;
                            logInOutHistoryFactory.Insert(logInOutHistory);

                            Response.Redirect("Default.aspx");
                        }
                        else
                        {
                            lblmessage.Visible = true;
                            lblmessage.ForeColor = System.Drawing.Color.Red;
                            lblmessage.Text = "نام کاربری شما غیر فعال می باشد.";
                        }
                    }
                    else
                    {
                        WrongLogin++;
                        RadCaptcha1.Visible = true;
                        lblmessage.Visible = true;
                        lblmessage.ForeColor = System.Drawing.Color.Red;
                        lblmessage.Text = "نام کاربری یا کلمه عبور اشتباه است.";
                    }
                }
                else
                {
                    WrongLogin++;
                    RadCaptcha1.Visible = true;
                    lblmessage.Visible = true;
                    lblmessage.ForeColor = System.Drawing.Color.Red;
                    lblmessage.Text = "نام کاربری یا کلمه عبور اشتباه است.";
                }
            }
        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                if (txtEmail.Text.Trim() != "")
                {
                    var u = _usersFactory.GetAllBy(Users.UsersFields.Email, txtEmail.Text);
                    if (u.Count > 0)
                    {
                        try
                        {
                            MailAddress mailfrom = new MailAddress("TradeManagement.Team@gmail.com");
                            MailAddress mailto = new MailAddress(txtEmail.Text);
                            MailMessage newmsg = new MailMessage(mailfrom, mailto);

                            string body =
                               "<div style='font:14px Tahoma;font-weight:600;color:#3f5c96;'>سیستم جامع بازرگانی خارجی</div><br>";
                            body += "<div style='font:12px Tahoma;font-weight:600;color:Green;'>بازیابی اطلاعات ورود</div><br>";
                            body += "<p style='font:12px Tahoma;'>کاربر گرامی اطلاعات ورود شما به شرح زیر می باشد: <br>";
                            body += "نام کاربری = " + u[0].UserName;
                            body += "<br />";
                            body += "کلمه عبور = " + u[0].Password;
                            body += "<br />";
                            body += "<br />";
                            body += "لطفا به این ایمیل پاسخ ندهید.";
                            body += "</p>";

                            newmsg.Subject = "بازیابی اطلاعات ورود";
                            newmsg.Body = body;
                            newmsg.IsBodyHtml = true;
                            newmsg.BodyEncoding = System.Text.Encoding.UTF8;

                            //For File Attachment, more file can also be attached
                            //Attachment att = new Attachment("C:\\...file path");
                            //newmsg.Attachments.Add(att);

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("TradeManagement.Team@gmail.com", "Trade123");
                            smtp.EnableSsl = true;
                            smtp.Send(newmsg);


                            lblmessage.Visible = true;
                            lblmessage.ForeColor = Color.Green;
                            lblmessage.Text = "ایمیلی حاوی نام کاربری و کلمه عبور برای شما ارسال گردید.";
                            divRecoveryPass.Visible = false;
                            divLogin.Visible = true;
                        }
                        catch (Exception)
                        {

                            lblmessage.Visible = true;
                            lblmessage.ForeColor = System.Drawing.Color.Red;
                            lblmessage.Text = "بروز خطا در انجام عملیات";
                        }
                    }
                    else
                    {
                        lblmessage.Visible = true;
                        lblmessage.ForeColor = System.Drawing.Color.Red;
                        lblmessage.Text = "این ایمیل در سیستم ثبت نشده است.";
                    }

                }
            }
            else
            {
                lblmessage.Visible = true;
                lblmessage.ForeColor = System.Drawing.Color.Red;
                lblmessage.Text = "کاربر گرامی برای انجام این درخواست سیستم باید به اینترنت متصل باشد.";
            }


        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


    }
}