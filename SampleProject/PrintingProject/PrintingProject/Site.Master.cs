using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingProject.BusinessLayer;
using Telerik.Web.UI;

namespace PrintingProject
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        UsersFactory _usersFactory = new UsersFactory();
        PagesFactory _pagesFactory = new PagesFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    var us = _usersFactory.GetAllBy(Users.UsersFields.Id, PrintingProject.Session.UserId);
                    lblwelcome.Text = us[0].Name + " خوش آمدید.";
                   
                    var ManagementPages = _pagesFactory.SelectByUserPermissions(PrintingProject.Session.UserId, 0);
                    var EnterMainInfoPages = _pagesFactory.SelectByUserPermissions(PrintingProject.Session.UserId, 1);
                    var EnterBaseInfoPages = _pagesFactory.SelectByUserPermissions(PrintingProject.Session.UserId, 2);
                    var ReportPages = _pagesFactory.SelectByUserPermissions(PrintingProject.Session.UserId, 3);
                    var ToolsPages = _pagesFactory.SelectByUserPermissions(PrintingProject.Session.UserId, 5);

                    if (ManagementPages.Count == 0)
                    {
                        trmanagementpic.Visible = false;
                        trmanagementdl.Visible = false;
                    }
                    else
                    {
                        trmanagementpic.Visible = true;
                        trmanagementdl.Visible = true;
                        dlManagementPages.DataSource = ManagementPages;
                        dlManagementPages.DataBind();
                    }
                    if (EnterMainInfoPages.Count == 0)
                    {
                        trentermaininfopic.Visible = false;
                        trentermaininfodl.Visible = false;
                    }
                    else
                    {
                        trentermaininfopic.Visible = true;
                        trentermaininfodl.Visible = true;
                        dlEnterMainInfoPages.DataSource = EnterMainInfoPages;
                        dlEnterMainInfoPages.DataBind();
                    }
                    if (EnterBaseInfoPages.Count == 0)
                    {
                        trenterbaseinfopic.Visible = false;
                        trenterbaseinfodl.Visible = false;
                    }
                    else
                    {
                        trenterbaseinfopic.Visible = true;
                        trenterbaseinfodl.Visible = true;
                        dlEnterBaseInfoPages.DataSource = EnterBaseInfoPages;
                        dlEnterBaseInfoPages.DataBind();
                    }
                    if (ReportPages.Count == 0)
                    {
                        trreportpic.Visible = false;
                        trreportdl.Visible = false;
                    }
                    else
                    {
                        trreportpic.Visible = true;
                        trreportdl.Visible = true;
                        dlReportsPages.DataSource = ReportPages;
                        dlReportsPages.DataBind();
                    }
                    if (ToolsPages.Count == 0)
                    {
                        trtoolspic.Visible = false;
                        trtoolsdl.Visible = false;
                    }
                    else
                    {
                        trtoolspic.Visible = true;
                        trtoolsdl.Visible = true;
                        dlToolsPages.DataSource = ToolsPages;
                        dlToolsPages.DataBind();
                    }

                    
                }
                catch (Exception)
                {

                    Response.Redirect("Login.aspx");
                }



            }
        }
        public static void ChangeFilterFunctionsName(GridFilterMenu menu)
        {
            for (int i = menu.Items.Count - 1; i >= 0; i--)
            {
                string farsiText = "";
                switch (menu.Items[i].Text)
                {
                    case "Contains":
                        farsiText = "شامل می شود";
                        break;
                    case "DoesNotContain":
                        farsiText = "شامل نمی شود";
                        break;
                    case "StartsWith":
                        farsiText = "شروع می شود با";
                        break;
                    case "EndsWith":
                        farsiText = "تمام می شود با";
                        break;
                    case "EqualTo":
                        farsiText = "برابر است با";
                        break;
                    case "NotEqualTo":
                        farsiText = "برابر نیست با";
                        break;
                    case "GreaterThan":
                        farsiText = "بزرگتر از";
                        break;
                    case "LessThan":
                        farsiText = "کوچکتر از";
                        break;
                    case "GreaterThanOrEqualTo":
                        farsiText = "بزرگتر مساوی با";
                        break;
                    case "LessThanOrEqualTo":
                        farsiText = "کوچکتر مساوی با";
                        break;
                    case "Between":
                        farsiText = "مابین";
                        break;
                    case "NotBetween":
                        farsiText = "غیر مابین";
                        break;
                    case "IsEmpty":
                        farsiText = "خالی است";
                        break;
                    case "NotIsEmpty":
                        farsiText = "خالی نیست";
                        break;
                    case "IsNull":
                        farsiText = "مقدار ندارد";
                        break;
                    case "NotIsNull":
                        farsiText = "مقدار دارد";
                        break;
                    case "Custom":
                        farsiText = "دستی";
                        break;
                    default:
                        farsiText = "";
                        break;
                }
                menu.Items[i].Text = farsiText;

            }
        }
        protected void imgbtnSignout_Click(object sender, ImageClickEventArgs e)
        {
            var logInOutHistory = new LogInOutHistories();
            var logInOutHistoryFactory = new LogInOutHistoriesFactory();

            logInOutHistory.Date = DateTime.Now;
            logInOutHistory.Type = false;
            logInOutHistory.UserId = PrintingProject.Session.UserId;

            logInOutHistoryFactory.Insert(logInOutHistory);
           
            PrintingProject.Session.IsLogin = false;
            Response.Redirect("Login.aspx");
        }

        protected void imgbtnHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void imgbtnconnect_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ConnectWithUs.aspx");
        }
    }
}
