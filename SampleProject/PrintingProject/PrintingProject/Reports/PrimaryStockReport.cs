namespace PrintingProject.Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using PrintingProject.BusinessLayer;
    using Telerik.Reporting;
    /// <summary>
    /// Summary description for PlateReport.
    /// </summary>
    public partial class PrimaryStockReport : Telerik.Reporting.Report
    {
        PrimaryStockFactory _primaryStockFactory = new PrimaryStockFactory();
        public PrimaryStockReport()
        {
            InitializeComponent();
        }
        
        private void PrimaryStockReport_NeedDataSource(object sender, EventArgs e)
        {
            var report = sender as Telerik.Reporting.Processing.Report;
            int id = Convert.ToInt32(ReportParameters["Id"].Value);
            var dt = _primaryStockFactory.ReportById(id);
            report.DataSource = dt;

            tblReport.DataSource = dt;
           
        }
    }
}