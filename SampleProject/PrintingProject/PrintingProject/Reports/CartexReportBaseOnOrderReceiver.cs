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
    public partial class CartexReportBaseOnOrderReceiver : Telerik.Reporting.Report
    {
        CartexesFactory _cartexesFactory = new CartexesFactory();

        public CartexReportBaseOnOrderReceiver()
        {
            InitializeComponent();
            PersianDateCal p = new PersianDateCal();
            txtDate.Value = p.ConvertToPersianDate(DateTime.Now, "Y/m/d");
        }
        private void CartexReportBaseOnOrderReceiver_ItemDataBinding(object sender, EventArgs e)
        {
            int? jobTypeId = ReportParameters["JobTypeId"].Value != null ? Convert.ToInt32(ReportParameters["JobTypeId"].Value) : (int?)null;
            string levelName = ReportParameters["LevelName"].Value != null ? ReportParameters["LevelName"].Value.ToString() : null;
            int? orderReceiverId = ReportParameters["OrderReceiverId"].Value != null ? Convert.ToInt32(ReportParameters["OrderReceiverId"].Value) : (int?)null;
            string receiptNum = ReportParameters["ReceiptNum"].Value != null ? ReportParameters["ReceiptNum"].Value.ToString() : null;
            int? inputInvoiceStatus = ReportParameters["InputInvoiceStatus"].Value != null ? Convert.ToInt32(ReportParameters["InputInvoiceStatus"].Value) : (int?)null;
            string inputInvoiceNum = ReportParameters["InputInvoiceNum"].Value != null ? ReportParameters["InputInvoiceNum"].Value.ToString() : null;
            int? customerId = ReportParameters["CustomerId"].Value != null ? Convert.ToInt32(ReportParameters["CustomerId"].Value) : (int?)null;
            string jobName = ReportParameters["JobName"].Value != null ? ReportParameters["JobName"].Value.ToString() : null;
            string jobCode = ReportParameters["JobCode"].Value != null ? ReportParameters["JobCode"].Value.ToString() : null;
            int? deliveryStatus = ReportParameters["DeliveryStatus"].Value != null ? Convert.ToInt32(ReportParameters["DeliveryStatus"].Value) : (int?)null;
            DateTime? startDate = ReportParameters["StartDate"].Value != null ? Convert.ToDateTime(ReportParameters["StartDate"].Value) : (DateTime?)null;
            DateTime? endDate = ReportParameters["EndDate"].Value != null ? Convert.ToDateTime(ReportParameters["EndDate"].Value) : (DateTime?)null;


            var dt = _cartexesFactory.ReportBaseOnOrderReceiver(jobTypeId, levelName, orderReceiverId,receiptNum,inputInvoiceStatus, inputInvoiceNum, customerId, jobName,
                jobCode,deliveryStatus, startDate, endDate);
            tblReport.DataSource = dt;

            object sumInputInvoiceCost;
            object sumOrderCount;
            object sumDeliveryCount;
            sumInputInvoiceCost = dt.Compute("Sum(InputInvoiceCost)", "");
            sumOrderCount = dt.Compute("Sum(OrderCount)", "");
            sumDeliveryCount = dt.Compute("Sum(DeliveryCount)", "");

            txtSumInputInvoices.Value = string.Format("{0:#,###0}", sumInputInvoiceCost);
            txtSumOrderCount.Value = string.Format("{0:#,###0}", sumOrderCount);
            txtSumDeliveryCount.Value = string.Format("{0:#,###0}", sumDeliveryCount);
        }
    }
}