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
    public partial class CartexProductStockReport : Telerik.Reporting.Report
    {
        CartexesFactory _cartexesFactory = new CartexesFactory();

        public CartexProductStockReport()
        {
            InitializeComponent();
            PersianDateCal p = new PersianDateCal();
            txtDate.Value = p.ConvertToPersianDate(DateTime.Now, "Y/m/d");
        }


        private void StockReportByInstitute_ItemDataBinding(object sender, EventArgs e)
        {
            int? orderReceiverId = ReportParameters["OrderReceiverId"].Value != null ? Convert.ToInt32(ReportParameters["OrderReceiverId"].Value) : (int?)null;
            string jobName = ReportParameters["JobName"].Value != null ? ReportParameters["JobName"].Value.ToString() : null;
            string jobCode = ReportParameters["JobCode"].Value != null ? ReportParameters["JobCode"].Value.ToString() : null;
            int? jobTypeId = ReportParameters["JobTypeId"].Value != null ? Convert.ToInt32(ReportParameters["JobTypeId"].Value) : (int?)null;

            var dt = _cartexesFactory.ReportProductStock(orderReceiverId, jobName, jobCode, jobTypeId);
            tblReport.DataSource = dt;
        }
    }
}