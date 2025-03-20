using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingProject.Reports;
using Telerik.Reporting;
using Telerik.Web.UI;
using System.Web.Script.Serialization;
using PrintingProject.BusinessLayer;


namespace PrintingProject
{
    public partial class BuyAndPreparingPaperReportManagement : System.Web.UI.Page
    {
        UserPageFactory _userPageFactory = new UserPageFactory();
        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        InstituteFactory _instituteFactory = new InstituteFactory();
        MaterialTypesFactory _materialTypesFactory = new MaterialTypesFactory();
        MaterialTypeGramazhFactory _materialTypeGramazhFactory = new MaterialTypeGramazhFactory();
        PaperHeightFactory _paperHeightFactory = new PaperHeightFactory();
        PaperWidthFactory _paperWidthFactory = new PaperWidthFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "BuyAndPreparingPaperReportManagement.aspx"))
                {
                    PrintingProject.Session.IsLogin = false; Response.Redirect("Login.aspx");
                }

                BindCmb();
            }
        }
        private void BindCmb()
        {
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(3);
            var orderReceiver = new OrderReceivers()
            {
                Id = 0,
                Name = "همه موارد"
            };
            var orderReceiver2 = new OrderReceivers()
            {
                Id = 9999999,
                Name = "هیچکدام"
            };

            lstOrderReceiver.Insert(0, orderReceiver);
            lstOrderReceiver.Insert(1, orderReceiver2);
            cmbOrderReceiver.DataSource = lstOrderReceiver;
            cmbOrderReceiver.DataBind();
            cmbOrderReceiver.SelectedIndex = 0;
          

            var lstInstituteSource = _instituteFactory.GetAll();
            var lstInstituteDestination = _instituteFactory.GetAll();

            var institute = new Institute()
            {
                Id = 0,
                Name = "همه موارد"
            };

            var institute2 = new Institute()
            {
                Id = 9999999,
                Name = "هیچکدام"
            };

            lstInstituteDestination.Insert(0, institute);
            cmbDestination.DataSource = lstInstituteDestination;
            cmbDestination.DataBind();
            cmbDestination.SelectedIndex = 0;

            lstInstituteSource.Insert(0, institute);
            lstInstituteSource.Insert(1, institute2);

            cmbSource.DataSource = lstInstituteSource;
            cmbSource.DataBind();
            cmbSource.SelectedIndex = 0;

            var lstMaterialType = _materialTypesFactory.GetAll();
            var materialType = new MaterialTypes()
            {
                Id = 0,
                Name = "همه موارد"
            };

            lstMaterialType.Insert(0, materialType);
            cmbMaterialType.DataSource = lstMaterialType;
            cmbMaterialType.DataBind();
            cmbMaterialType.SelectedIndex = 0;

            var lstMaterialTypeGramazh = _materialTypeGramazhFactory.GetAll();
            var materialTypeGramazh = new MaterialTypeGramazh()
            {
                Id = 0,
                Name = "همه موارد"
            };

            lstMaterialTypeGramazh.Insert(0, materialTypeGramazh);
            cmbMaterialTypeGramazh.DataSource = lstMaterialTypeGramazh;
            cmbMaterialTypeGramazh.DataBind();
            cmbMaterialTypeGramazh.SelectedIndex = 0;

            var lstPaperHeight = _paperHeightFactory.GetAll();
            var paperHeight = new PaperHeight()
            {
                Id = 0,
                Name = "همه موارد"
            };

            lstPaperHeight.Insert(0, paperHeight);
            cmbPaperHeight.DataSource = lstPaperHeight;
            cmbPaperHeight.DataBind();
            cmbPaperHeight.SelectedIndex = 0;

            var lstPaperWidth = _paperWidthFactory.GetAll();
            var paperWidth = new PaperWidth()
            {
                Id = 0,
                Name = "همه موارد"
            };

            lstPaperWidth.Insert(0, paperWidth);
            cmbPaperWidth.DataSource = lstPaperWidth;
            cmbPaperWidth.DataBind();
            cmbPaperWidth.SelectedIndex = 0;

        }
        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            var r = new BuyAndPreparingPaperReport();

            r.ReportParameters["OrderReceiverId"].Value = cmbOrderReceiver.SelectedValue != "0"
              ? cmbOrderReceiver.SelectedValue
              : null;
            r.ReportParameters["SourceId"].Value = cmbSource.SelectedValue != "0"
                ? cmbSource.SelectedValue
                : null;
            r.ReportParameters["DestinationId"].Value = cmbDestination.SelectedValue != "0"
                ? cmbDestination.SelectedValue
                : null;
            r.ReportParameters["MaterialTypeId"].Value = cmbMaterialType.SelectedValue != "0"
                ? cmbMaterialType.SelectedValue
                : null;
            r.ReportParameters["MaterialTypeGramazhId"].Value = cmbMaterialTypeGramazh.SelectedValue != "0"
                ? cmbMaterialTypeGramazh.SelectedValue
                : null;
            r.ReportParameters["PaperWidthId"].Value = cmbPaperWidth.SelectedValue != "0"
                ? cmbPaperWidth.SelectedValue
                : null;
            r.ReportParameters["PaperHeightId"].Value = cmbPaperHeight.SelectedValue != "0"
                ? cmbPaperHeight.SelectedValue
                : null;
            r.ReportParameters["StartDate"].Value = dtpFromDate.Date;
            r.ReportParameters["EndDate"].Value = dtpToDate.Date;
            ReportViewer1.ReportSource = r;
            ReportViewer1.Visible = true;
        }

       

    }
}