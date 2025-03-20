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
    public partial class CartexReportBaseOnOrderReceiverManagement : System.Web.UI.Page
    {
        OrderReceivers _orderReceivers = new OrderReceivers();
        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        UserPageFactory _userPageFactory = new UserPageFactory();
        CartexesFactory _cartexesFactory = new CartexesFactory();
        CustomersFactory _customersFactory = new CustomersFactory();
        JobTypesFactory _jobTypesFactory = new JobTypesFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "CartexReportBaseOnOrderReceiverManagement.aspx"))
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


            var lstCustomers = _customersFactory.GetAll();
            var customer = new Customers()
            {
                Id = 0,
                Name = "همه موارد"
            };

            lstCustomers.Insert(0, customer);
            comboCustomers.DataSource = lstCustomers;
            comboCustomers.DataBind();


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
            var r = new CartexReportBaseOnOrderReceiver();
            r.ReportParameters["JobTypeId"].Value = comboJobType.SelectedValue != "0"
                                                         ? comboJobType.SelectedValue
                                                         : null;
            r.ReportParameters["LevelName"].Value = comboLevelName.SelectedValue != "0"
                                                        ? comboLevelName.Text
                                                        : null;
            r.ReportParameters["OrderReceiverId"].Value = comboOrderReceivers.SelectedValue != "0"
                                                          ? comboOrderReceivers.SelectedValue
                                                          : null;
            r.ReportParameters["ReceiptNum"].Value = !string.IsNullOrEmpty(txtReceiptNum.Text) ? txtReceiptNum.Text : null;
            r.ReportParameters["InputInvoiceStatus"].Value = comboInputInvoiceStatus.SelectedValue != ""
                                                            ? comboInputInvoiceStatus.SelectedValue
                                                            : null;
            r.ReportParameters["InputInvoiceNum"].Value = !string.IsNullOrEmpty(txtInputInvoiceNum.Text) ? txtInputInvoiceNum.Text : null;
            r.ReportParameters["CustomerId"].Value = comboCustomers.SelectedValue != "0"
                                                         ? comboCustomers.SelectedValue
                                                         : null;
            r.ReportParameters["JobName"].Value = comboJobName.SelectedIndex != 0 ? comboJobName.Text : null;
            r.ReportParameters["JobCode"].Value = comboJobCode.SelectedIndex != 0 ? comboJobCode.Text : null;
            r.ReportParameters["DeliveryStatus"].Value = comboDeliveryStatus.SelectedValue != ""
                                                         ? comboDeliveryStatus.SelectedValue
                                                         : null;
            r.ReportParameters["StartDate"].Value = dtpFromDate.Date;
            r.ReportParameters["EndDate"].Value = dtpToDate.Date;
            ReportViewer1.ReportSource = r;
            ReportViewer1.Visible = true;
        }



        protected void comboCustomers_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            var customerId = int.Parse(comboCustomers.SelectedValue) == 0 ? (int?)null : int.Parse(comboCustomers.SelectedValue);

            if (customerId == null)
            {
                var lstJobNames = _cartexesFactory.GetAll();
                var cartex = new Cartexes()
                {
                    Id = 0,
                    CustomerId = 0,
                    JobName = "همه موارد",
                    JobCode = "0",
                    Description = ""
                };

                lstJobNames.Insert(0, cartex);
                comboJobName.DataSource = lstJobNames;
                comboJobName.DataBind();
                comboJobName.SelectedIndex = 0;
            }
            else
            {
                var lstJobNames = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.CustomerId, customerId);
                var cartex = new Cartexes()
                {
                    Id = 0,
                    CustomerId = 0,
                    JobName = "همه موارد",
                    JobCode = "0",
                    Description = ""
                };
                lstJobNames.Insert(0, cartex);
                comboJobName.DataSource = lstJobNames;
                comboJobName.DataBind();
            }
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