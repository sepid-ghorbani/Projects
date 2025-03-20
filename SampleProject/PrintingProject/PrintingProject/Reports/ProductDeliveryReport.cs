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
    public partial class ProductDeliveryReport : Telerik.Reporting.Report
    {
        ProductDeliveryFactory _productDeliveryFactory = new ProductDeliveryFactory();
        public ProductDeliveryReport()
        {
            InitializeComponent();
        }

        private void ProductDeliveryReport_NeedDataSource(object sender, EventArgs e)
        {
            var report = sender as Telerik.Reporting.Processing.Report;
            int id = Convert.ToInt32(ReportParameters["Id"].Value);
            var dt = _productDeliveryFactory.ReportById(id);
            report.DataSource = dt;

            tblReport.DataSource = dt;
            table1.DataSource = dt;
        }
    }
}