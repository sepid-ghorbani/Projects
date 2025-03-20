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
    public partial class StockReportByInstitute : Telerik.Reporting.Report
    {
        StockFactory _stockFactory = new StockFactory();

        public StockReportByInstitute()
        {
            InitializeComponent();
            PersianDateCal p = new PersianDateCal();
            txtDate.Value = p.ConvertToPersianDate(DateTime.Now, "Y/m/d");
        }


        private void StockReportByInstitute_ItemDataBinding(object sender, EventArgs e)
        {
            int? instituteId = ReportParameters["InstituteId"].Value != null ? Convert.ToInt32(ReportParameters["InstituteId"].Value) : (int?)null;

            var dt = _stockFactory.ReportByInstitute(instituteId);
            tblReport.DataSource = dt;
        }
    }
}