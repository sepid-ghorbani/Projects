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
using PrintingProject.Reports;

namespace PrintingProject
{
    public partial class ReportBaseOnOrderReceiverManagement : System.Web.UI.Page
    {
        OrderReceivers _orderReceivers = new OrderReceivers();
        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        UserPageFactory _userPageFactory = new UserPageFactory();
        JobsFactory _jobsFactory = new JobsFactory();
        CustomersFactory _customersFactory = new CustomersFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "ReportBaseOnOrderReceiverManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }

                BindCmb();
            }
        }

        private void BindCmb()
        {

            var lstOrderReceiver = _orderReceiversFactory.GetAll();
            _orderReceivers.Id = 0;

            _orderReceivers.Name = "همه موارد";
            lstOrderReceiver.Insert(0, _orderReceivers);

            comboOrderReceivers.DataSource = lstOrderReceiver;
            comboOrderReceivers.DataBind();


            var lstCustomers = _customersFactory.GetAll();
            var customer = new Customers()
            {
                Id = 0,
                Name = "همه موارد"
            };

            lstCustomers.Insert(0, customer);
            comboCustomers.DataSource = lstCustomers;
            comboCustomers.DataBind();


            var lstJobNames = _jobsFactory.GetAllInserted(null);
            var job = new Jobs()
            {
                Id = 0,
                Name = "همه موارد"
            };
            lstJobNames.Insert(0, job);
            comboJobName.DataSource = lstJobNames;
            comboJobName.DataBind();
            comboJobName.SelectedIndex = 0;


        }

        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            var r = new ReportBaseOnOrderReceiver();
            r.ReportParameters["LevelName"].Value = comboLevelName.SelectedValue != "0"
                                                        ? comboLevelName.Text
                                                        : null;
            r.ReportParameters["OrderReceiverId"].Value = comboOrderReceivers.SelectedValue != "0"
                                                          ? comboOrderReceivers.SelectedValue
                                                          : null;
            r.ReportParameters["InvoiceStatus"].Value = comboInvoiceStatus.SelectedValue != "0"
                                                            ? comboInvoiceStatus.Text
                                                            : null;
            r.ReportParameters["InvoiceNum"].Value = !string.IsNullOrEmpty(txtInvoiceNum.Text) ? txtInvoiceNum.Text : null;
            r.ReportParameters["CustomerId"].Value = comboCustomers.SelectedValue != "0"
                                                         ? comboCustomers.SelectedValue
                                                         : null;
            r.ReportParameters["JobName"].Value = comboJobName.SelectedValue != "0"  ? comboJobName.Text : null;
            r.ReportParameters["JobNum"].Value = !string.IsNullOrEmpty(txtJobNum.Text) ? txtJobNum.Text : null;
            r.ReportParameters["StartDate"].Value = dtpFromDate.Date;
            r.ReportParameters["EndDate"].Value = dtpToDate.Date;
            ReportViewer1.ReportSource = r;
            ReportViewer1.Visible = true;
        }

        protected void comboLevelName_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            int level = int.Parse(comboLevelName.SelectedValue);
            if (level != 0)
            {
                var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(level);
                _orderReceivers.Id = 0;
                _orderReceivers.Name = "همه موارد";
                lstOrderReceiver.Insert(0, _orderReceivers);

                comboOrderReceivers.DataSource = lstOrderReceiver;
                comboOrderReceivers.DataBind();
            }
            else
            {
                var lstOrderReceiver = _orderReceiversFactory.GetAll();
                _orderReceivers.Id = 0;
                _orderReceivers.Name = "همه موارد";
                lstOrderReceiver.Insert(0, _orderReceivers);

                comboOrderReceivers.DataSource = lstOrderReceiver;
                comboOrderReceivers.DataBind();
            }

        }

        protected void comboCustomers_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            var customerId = int.Parse(comboCustomers.SelectedValue) == 0 ? (int?)null : int.Parse(comboCustomers.SelectedValue);

            var lstJobNames = _jobsFactory.GetAllInserted(customerId);
            var job = new Jobs()
            {
                Id = 0,
                Name = "همه موارد"
            };
            lstJobNames.Insert(0, job);
            comboJobName.DataSource = lstJobNames;
            comboJobName.DataBind();
        }


    }
}