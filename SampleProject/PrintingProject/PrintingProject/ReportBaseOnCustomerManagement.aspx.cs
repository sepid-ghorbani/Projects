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
    public partial class ReportBaseOnCustomerManagement : System.Web.UI.Page
    {
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
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "ReportBaseOnCustomerManagement.aspx"))
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
            var r = new ReportBaseOnCustomer();
            r.ReportParameters["InvoiceStatus"].Value = comboInvoiceStatus.SelectedValue != "0"
                                                            ? comboInvoiceStatus.Text
                                                            : null;
            r.ReportParameters["CutomerId"].Value = comboCustomers.SelectedValue != "0"
                                                          ? comboCustomers.SelectedValue
                                                          : null;
            r.ReportParameters["JobName"].Value = comboJobName.SelectedValue != "0"  ? comboJobName.Text : null;
            r.ReportParameters["JobNum"].Value = !string.IsNullOrEmpty(txtJobNum.Text) ? txtJobNum.Text : null;
            r.ReportParameters["StartDate"].Value = dtpFromDate.Date;
            r.ReportParameters["EndDate"].Value = dtpToDate.Date;
            ReportViewer1.ReportSource = r;
            ReportViewer1.Visible = true;
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