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
    public partial class CartexReportBaseOnCustomer : Telerik.Reporting.Report
    {
        CartexesFactory _cartexesFactory = new CartexesFactory();
        public CartexReportBaseOnCustomer()
        {
            InitializeComponent();
            PersianDateCal p = new PersianDateCal();
            txtDate.Value = p.ConvertToPersianDate(DateTime.Now, "Y/m/d");
        }

    

        private void CartexReportBaseOnCustomer_ItemDataBinding(object sender, EventArgs e)
        {
            int? customerId = ReportParameters["CustomerId"].Value != null ? Convert.ToInt32(ReportParameters["CustomerId"].Value) : (int?)null;
            string jobName = ReportParameters["JobName"].Value != null ? ReportParameters["JobName"].Value.ToString() : null;
            string jobCode = ReportParameters["JobCode"].Value != null ? ReportParameters["JobCode"].Value.ToString() : null;
            int? inputInvoiceStatus = ReportParameters["InputInvoiceStatus"].Value != null ? Convert.ToInt32(ReportParameters["InputInvoiceStatus"].Value) : (int?)null;
            int? outputInvoiceStatus = ReportParameters["OutputInvoiceStatus"].Value != null ? Convert.ToInt32(ReportParameters["OutputInvoiceStatus"].Value) : (int?)null;
            int? deliveryStatus = ReportParameters["DeliveryStatus"].Value != null ? Convert.ToInt32(ReportParameters["DeliveryStatus"].Value) : (int?)null;
            string outputInvoiceNum = ReportParameters["OutputInvoiceNum"].Value != null ? ReportParameters["OutputInvoiceNum"].Value.ToString() : null;
            DateTime? startDate = ReportParameters["StartDate"].Value != null ? Convert.ToDateTime(ReportParameters["StartDate"].Value) : (DateTime?)null;
            DateTime? endDate = ReportParameters["EndDate"].Value != null ? Convert.ToDateTime(ReportParameters["EndDate"].Value) : (DateTime?)null;


            var dt = _cartexesFactory.ReportBaseOnCustomer(customerId, jobName, jobCode, inputInvoiceStatus, outputInvoiceStatus, deliveryStatus,
                outputInvoiceNum, startDate, endDate);
            tblReport.DataSource = dt;

            object sumInputInvoiceCost;
            object sumOutputInvoiceCost;
            object sumOrderCount;
            object sumDeliveryCount;

            sumInputInvoiceCost = dt.Compute("Sum(InputInvoiceCost)", "");
            sumOutputInvoiceCost = dt.Compute("Sum(OutputInvoiceCost)", "");
            sumOrderCount = dt.Compute("Sum(OrderCount)", "");
            sumDeliveryCount = dt.Compute("Sum(DeliveryCount)", "");

            txtSumInputInvoices.Value = string.Format("{0:#,###0}", sumInputInvoiceCost);
            txtSumOutputInvoices.Value = string.Format("{0:#,###0}", sumOutputInvoiceCost);
            txtSumOrderCount.Value = string.Format("{0:#,###0}", sumOrderCount);
            txtSumDeliveryCount.Value = string.Format("{0:#,###0}", sumDeliveryCount);
        }
    }
}