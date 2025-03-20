namespace PrintingProject.Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using PrintingProject.BusinessLayer;
    /// <summary>
    /// Summary description for ReportBaseOnCustomer.
    /// </summary>
    public partial class ReportBaseOnOrderReceiver : Telerik.Reporting.Report
    {
        JobsFactory _jobsFactory = new JobsFactory();

        public ReportBaseOnOrderReceiver()
        {
            InitializeComponent();
            PersianDateCal p = new PersianDateCal();
            txtDate.Value = p.ConvertToPersianDate(DateTime.Now, "Y/m/d");
        }

        private void ReportBaseOnOrderReceiver_ItemDataBinding(object sender, EventArgs e)
        {
            string levelName = ReportParameters["LevelName"].Value != null ? ReportParameters["LevelName"].Value.ToString() : null;
            int? orderReceiverId = ReportParameters["OrderReceiverId"].Value != null ? Convert.ToInt32(ReportParameters["OrderReceiverId"].Value) : (int?)null;
            string invoiceStatus = ReportParameters["InvoiceStatus"].Value != null ? ReportParameters["InvoiceStatus"].Value.ToString() : null;
            int? invoiceNum = ReportParameters["InvoiceNum"].Value != null ? Convert.ToInt32(ReportParameters["InvoiceNum"].Value) : (int?)null;
            int? customerId = ReportParameters["CustomerId"].Value != null ? Convert.ToInt32(ReportParameters["CustomerId"].Value) : (int?)null;
            string jobName = ReportParameters["JobName"].Value != null ? ReportParameters["JobName"].Value.ToString() : null;
            int? jobNum = ReportParameters["JobNum"].Value != null ? Convert.ToInt32(ReportParameters["JobNum"].Value) : (int?)null;
            DateTime? startDate = ReportParameters["StartDate"].Value != null ? Convert.ToDateTime(ReportParameters["StartDate"].Value) : (DateTime?)null;
            DateTime? endDate = ReportParameters["EndDate"].Value != null ? Convert.ToDateTime(ReportParameters["EndDate"].Value) : (DateTime?)null;


            var dt = _jobsFactory.ReportBaseOnOrderReceiver(levelName, orderReceiverId, invoiceStatus, invoiceNum,customerId,
                                                            jobName, jobNum, startDate, endDate);
            tblReport.DataSource = dt;

            object sumObject;
            sumObject = dt.Compute("Sum(InvoiceCost)", "");
            txtSumAll.Value = string.Format("{0:#,###0}", sumObject);
        }
    }
}