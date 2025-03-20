using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingProject.Reports;
namespace PrintingProject
{
    public partial class PrintPreviewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var queryString = Request.QueryString.Keys[0];

                switch (queryString)
                {
                    case "PlateId":
                        {
                            var r = new PlateReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["PlateId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "FilmId":
                        {
                            var r = new FilmReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["FilmId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "CopyZinkId":
                        {
                            var r = new CopyZinkReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["CopyZinkId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "StereotypeId":
                        {
                            var r = new StereotypeReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["StereotypeId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "PrintingId":
                        {
                            var r = new PrintingReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["PrintingId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "BuyPaperId":
                        {
                            var r = new BuyPaperReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["BuyPaperId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "PreparingPaperId":
                        {
                            var r = new PreparingPaperReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["PreparingPaperId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "UsePaperId":
                        {
                            var r = new UsePaperReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["UsePaperId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "VeneerId":
                        {
                            var r = new VeneerReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["VeneerId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "LetterPressId":
                        {
                            var r = new LetterPressReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["LetterPressId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "MakingTemplateId":
                        {
                            var r = new MakingTemplateReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["MakingTemplateId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "SahafiId":
                        {
                            var r = new SahafiReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["SahafiId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "FinalInvoiceId":
                        {
                            var r = new FinalInvoiceReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["FinalInvoiceId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "PrimaryStockId":
                        {
                            var r = new PrimaryStockReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["PrimaryStockId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "ProductionOrderId":
                        {
                            var r = new ProductionOrderReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["ProductionOrderId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }
                    case "ProductDeliveryId":
                        {
                            var r = new ProductDeliveryReport();
                            r.ReportParameters["Id"].Value = int.Parse(Request.QueryString["ProductDeliveryId"]);
                            ReportViewer1.ReportSource = r;
                            break;
                        }

                }


            }
        }
    }
}