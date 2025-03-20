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
    public partial class CartexReportBaseOnCustomerManagement : System.Web.UI.Page
    {
        UserPageFactory _userPageFactory = new UserPageFactory();
        CustomersFactory _customersFactory = new CustomersFactory();
        CartexesFactory _cartexesFactory = new CartexesFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "CartexReportBaseOnCustomerManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }

                BindCmb();
            }
        }
        private void BindCmb()
        {
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

        }
        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            var r = new CartexReportBaseOnCustomer();

            r.ReportParameters["CustomerId"].Value = comboCustomers.SelectedValue != "0"
                                                               ? comboCustomers.SelectedValue
                                                               : null;
            r.ReportParameters["JobName"].Value = comboJobName.SelectedIndex != 0 ? comboJobName.Text : null;
            r.ReportParameters["JobCode"].Value = comboJobCode.SelectedIndex != 0 ? comboJobCode.Text : null;
            r.ReportParameters["InputInvoiceStatus"].Value = comboInputInvoiceStatus.SelectedValue != ""
                                                             ? comboInputInvoiceStatus.SelectedValue
                                                             : null;
            r.ReportParameters["OutputInvoiceStatus"].Value = comboOutputInvoiceStatus.SelectedValue != ""
                                                            ? comboOutputInvoiceStatus.SelectedValue
                                                            : null;
            r.ReportParameters["DeliveryStatus"].Value = comboDeliveryStatus.SelectedValue != ""
                                                           ? comboDeliveryStatus.SelectedValue
                                                           : null;
            r.ReportParameters["OutputInvoiceNum"].Value = !string.IsNullOrEmpty(txtOutputInvoiceNum.Text) ? txtOutputInvoiceNum.Text : null;
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