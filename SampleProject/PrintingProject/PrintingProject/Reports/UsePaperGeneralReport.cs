using System.Security.Cryptography;

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
    public partial class UsePaperGeneralReport : Telerik.Reporting.Report
    {
        UsePaperFactory _usePaperFactory = new UsePaperFactory();
        public UsePaperGeneralReport()
        {
            InitializeComponent();
            PersianDateCal p = new PersianDateCal();
            txtDate.Value = p.ConvertToPersianDate(DateTime.Now, "Y/m/d");
        }



        private void UsePaperGeneralReport_ItemDataBinding(object sender, EventArgs e)
        {
            int? customerId = ReportParameters["CustomerId"].Value != null ? Convert.ToInt32(ReportParameters["CustomerId"].Value) : (int?)null;
            int? sourceId = ReportParameters["SourceId"].Value != null ? Convert.ToInt32(ReportParameters["SourceId"].Value) : (int?)null;
            int? materialTypeId = ReportParameters["MaterialTypeId"].Value != null ? Convert.ToInt32(ReportParameters["MaterialTypeId"].Value) : (int?)null;
            int? materialTypeGramazhId = ReportParameters["MaterialTypeGramazhId"].Value != null ? Convert.ToInt32(ReportParameters["MaterialTypeGramazhId"].Value) : (int?)null;
            int? paperWidthId = ReportParameters["PaperWidthId"].Value != null ? Convert.ToInt32(ReportParameters["PaperWidthId"].Value) : (int?)null;
            int? paperHeightId = ReportParameters["PaperHeightId"].Value != null ? Convert.ToInt32(ReportParameters["PaperHeightId"].Value) : (int?)null;
            DateTime? startDate = ReportParameters["StartDate"].Value != null ? Convert.ToDateTime(ReportParameters["StartDate"].Value) : (DateTime?)null;
            DateTime? endDate = ReportParameters["EndDate"].Value != null ? Convert.ToDateTime(ReportParameters["EndDate"].Value) : (DateTime?)null;
            int? useStatus = ReportParameters["UseStatus"].Value != null ? Convert.ToInt32(ReportParameters["UseStatus"].Value) : (int?)null;

            var dt = _usePaperFactory.UsePaperGeneralReport(customerId, sourceId, materialTypeId, materialTypeGramazhId, paperWidthId, paperHeightId, startDate, endDate, useStatus);
            tblReport.DataSource = dt;
        }


    }
}