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
    public partial class CartexProductStockReportManagement : System.Web.UI.Page
    {
        UserPageFactory _userPageFactory = new UserPageFactory();
        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        CartexesFactory _cartexesFactory = new CartexesFactory();
        JobTypesFactory _jobTypesFactory = new JobTypesFactory();
        OrderReceivers _orderReceivers = new OrderReceivers();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "CartexProductStockReportManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }

                BindCmb();

            }
        }

        private void BindCmb()
        {

            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(8);
            _orderReceivers.Id = 0;
            _orderReceivers.Name = "همه موارد";
            lstOrderReceiver.Insert(0, _orderReceivers);

            comboOrderReceivers.DataSource = lstOrderReceiver;
            comboOrderReceivers.DataBind();

            var lstJobNames = _cartexesFactory.GetAllJobNames();
            var cartex = new Cartexes()
            {
                Id = 0,
                CustomerId = 0,
                JobName = "همه موارد",
                JobCode = "همه موارد",
                Description = ""
            };

            lstJobNames.Insert(0, cartex);
            comboJobName.DataSource = lstJobNames;
            comboJobName.DataBind();
            comboJobName.SelectedIndex = 0;

            var lstJobCodes = _cartexesFactory.GetAllJobCodes();
            var jobCode = new Cartexes()
            {
                Id = 0,
                CustomerId = 0,
                JobName = "همه موارد",
                JobCode = "همه موارد",
                Description = ""
            };

            lstJobCodes.Insert(0, jobCode);
            comboJobCode.DataSource = lstJobCodes;
            comboJobCode.DataBind();
            comboJobCode.SelectedIndex = 0;

            var lstJobType = _jobTypesFactory.GetAll();
            var jobType = new JobTypes()
            {
                Id = 0,
                Name = "همه موارد"
            };
            lstJobType.Insert(0, jobType);
            comboJobType.DataSource = lstJobType;
            comboJobType.DataBind();

        }
        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            var r = new CartexProductStockReport();
            r.ReportParameters["OrderReceiverId"].Value = comboOrderReceivers.SelectedValue != "0"
                                                          ? comboOrderReceivers.SelectedValue
                                                          : null;
            r.ReportParameters["JobTypeId"].Value = comboJobType.SelectedValue != "0"
                                                         ? comboJobType.SelectedValue
                                                         : null;
            r.ReportParameters["JobName"].Value = comboJobName.SelectedIndex != 0 ? comboJobName.Text : null;
            r.ReportParameters["JobCode"].Value = comboJobCode.SelectedIndex != 0 ? comboJobCode.Text : null;

            ReportViewer1.ReportSource = r;
            ReportViewer1.Visible = true;
        }

     
        protected void comboJobName_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            var jobCode = comboJobName.SelectedIndex == 0 ? null : comboJobName.SelectedValue;

            if (jobCode != null)
            {
                comboJobCode.SelectedValue = jobCode;
            }
            else
            {
                comboJobCode.SelectedIndex = 0;
            }

        }

    }
}