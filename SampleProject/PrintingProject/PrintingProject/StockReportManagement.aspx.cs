using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingProject.Reports;
using Telerik.Reporting;
using Telerik.Web.UI;
using System.Web.Script.Serialization;
using PrintingProject.BusinessLayer;


namespace PrintingProject
{
    public partial class StockReportManagement : System.Web.UI.Page
    {
        UserPageFactory _userPageFactory = new UserPageFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "StockReportManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }


            }
        }

        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            var r = new StockReportByInstitute();
            r.ReportParameters["InstituteId"].Value = comboInstitute.SelectedValue != "0"
                                                            ? comboInstitute.SelectedValue
                                                            : null;
            ReportViewer1.ReportSource = r;
            ReportViewer1.Visible = true;
        }


    }
}