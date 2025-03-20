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
    public partial class BuyAndPreparingPaperReport : Telerik.Reporting.Report
    {
        BuyPaperFactory _buyPaperFactory = new BuyPaperFactory();
        public BuyAndPreparingPaperReport()
        {
            InitializeComponent();
            PersianDateCal p = new PersianDateCal();
            txtDate.Value = p.ConvertToPersianDate(DateTime.Now, "Y/m/d");
        }



        private void BuyAndPreparingPaperReport_ItemDataBinding(object sender, EventArgs e)
        {
            int? orderReceiverId = ReportParameters["OrderReceiverId"].Value != null ? Convert.ToInt32(ReportParameters["OrderReceiverId"].Value) : (int?)null;
            int? sourceId = ReportParameters["SourceId"].Value != null ? Convert.ToInt32(ReportParameters["SourceId"].Value) : (int?)null;
            int? destinationId = ReportParameters["DestinationId"].Value != null ? Convert.ToInt32(ReportParameters["DestinationId"].Value) : (int?)null;
            int? materialTypeId = ReportParameters["MaterialTypeId"].Value != null ? Convert.ToInt32(ReportParameters["MaterialTypeId"].Value) : (int?)null;
            int? materialTypeGramazhId = ReportParameters["MaterialTypeGramazhId"].Value != null ? Convert.ToInt32(ReportParameters["MaterialTypeGramazhId"].Value) : (int?)null;
            int? paperWidthId = ReportParameters["PaperWidthId"].Value != null ? Convert.ToInt32(ReportParameters["PaperWidthId"].Value) : (int?)null;
            int? paperHeightId = ReportParameters["PaperHeightId"].Value != null ? Convert.ToInt32(ReportParameters["PaperHeightId"].Value) : (int?)null;
            DateTime? startDate = ReportParameters["StartDate"].Value != null ? Convert.ToDateTime(ReportParameters["StartDate"].Value) : (DateTime?)null;
            DateTime? endDate = ReportParameters["EndDate"].Value != null ? Convert.ToDateTime(ReportParameters["EndDate"].Value) : (DateTime?)null;


            var dt = _buyPaperFactory.BuyAndPreparingPaperReport(orderReceiverId,sourceId, destinationId, materialTypeId, materialTypeGramazhId, paperWidthId, paperHeightId, startDate, endDate);
            tblReport.DataSource = dt;
        }


    }
}