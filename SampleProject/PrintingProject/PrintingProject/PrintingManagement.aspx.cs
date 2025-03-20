using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Web.Script.Serialization;
using PrintingProject.BusinessLayer;


namespace PrintingProject
{
    public partial class PrintingManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        Printings _printings = new Printings();
        PrintingsFactory _printingsFactory = new PrintingsFactory();

        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        PrintTypesFactory _printTypesFactory = new PrintTypesFactory();
        ZinkTypesFactory _zinkTypesFactory = new ZinkTypesFactory();
        PrintModelsFactory _printModelsFactory = new PrintModelsFactory();
        MaterialTypesFactory _materialTypesFactory = new MaterialTypesFactory();
        MaterialTypeGramazhFactory _materialTypeGramazhFactory = new MaterialTypeGramazhFactory();
        MainColorCountFactory _mainColorCountFactory = new MainColorCountFactory();
        MainColorCount _mainColorCount = new MainColorCount();
        ExportColorsFactory _exportColorsFactory = new ExportColorsFactory();
        JobsFactory _jobsFactory = new JobsFactory();
        UserPageFactory _userPageFactory = new UserPageFactory();
        PaperWidthFactory _paperWidthFactory = new PaperWidthFactory();
        PaperHeightFactory _paperHeightFactory = new PaperHeightFactory();

        UsePaper _usePaper = new UsePaper();
        UsePaperFactory _usePaperFactory = new UsePaperFactory();

        Stock _stock = new Stock();
        StockFactory _stockFactory = new StockFactory();
        InstituteFactory _instituteFactory = new InstituteFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "PrintingManagement.aspx"))
                {
                    PrintingProject.Session.IsLogin = false; Response.Redirect("Login.aspx");
                }
                BindCmb();
                BindGrid();
                ClearFrom();
                ChangeButtonsEnable("Normal");

                int jobId = int.Parse(Request.QueryString["JId"]);
                var job = _jobsFactory.GetAllBy(Jobs.JobsFields.Id, jobId)[0];
                lblJobName.Text = job.Id.ToString() + " - " + job.Name;
                PersianDateCal p = new PersianDateCal();
                lblJobCreateDate.Text = p.ConvertToPersianDate(job.CreateDate, "Y/m/d");
                lblJobCode.Text = job.Code;

                HyperLinkLitography.NavigateUrl = "~/LitographyManagement.aspx?JId=" + Request.QueryString["JId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkPrinting.NavigateUrl = "~/PrintingManagement.aspx?JId=" + Request.QueryString["JId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkPaper.NavigateUrl = "~/PaperManagement.aspx?JId=" + Request.QueryString["JId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkVeneer.NavigateUrl = "~/VeneerManagement.aspx?JId=" + Request.QueryString["JId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkLetterPress.NavigateUrl = "~/LetterPressManagement.aspx?JId=" + Request.QueryString["JId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkMakingTemplate.NavigateUrl = "~/MakingTemplateManagement.aspx?JId=" + Request.QueryString["JId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkSahafi.NavigateUrl = "~/SahafiManagement.aspx?JId=" + Request.QueryString["JId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkFinalInvoice.NavigateUrl = "~/FinalInvoiceManagement.aspx?JId=" + Request.QueryString["JId"] + "&Index=" + Request.QueryString["Index"];

            }
        }
        private void BindCmb()
        {
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(2);
            cmbOrderReceiver.DataSource = lstOrderReceiver;
            cmbOrderReceiver.DataBind();

            var lstPrintType = _printTypesFactory.GetAll();
            cmbPrintType.DataSource = lstPrintType;
            cmbPrintType.DataBind();

            var lstZinkType = _zinkTypesFactory.GetAll();
            cmbZinkType.DataSource = lstZinkType;
            cmbZinkType.DataBind();

            var lstPrintModel = _printModelsFactory.GetAll();
            cmbPrintModel.DataSource = lstPrintModel;
            cmbPrintModel.DataBind();

            var lstMaterialType = _materialTypesFactory.GetAll();
            cmbMaterialType.DataSource = lstMaterialType;
            cmbMaterialType.DataBind();

            var lstMaterialTypeGramazh = _materialTypeGramazhFactory.GetAll();
            cmbMaterialTypeGramazh.DataSource = lstMaterialTypeGramazh;
            cmbMaterialTypeGramazh.DataBind();

            var lstMainColorCount = _mainColorCountFactory.GetAll();
            _mainColorCount.Id = 0;
            _mainColorCount.Name = "ندارد";
            lstMainColorCount.Insert(0, _mainColorCount);

            cmbMainColorCount.DataSource = lstMainColorCount;
            cmbMainColorCount.DataBind();

            cmbSpotColorCount.DataSource = lstMainColorCount;
            cmbSpotColorCount.DataBind();

            var lstExportColor = _exportColorsFactory.GetAll();
            cmbExportColor.DataSource = lstExportColor;
            cmbExportColor.DataBind();


            var lstPaperWidth = _paperWidthFactory.GetAll();
            cmbPaperWidth.DataSource = lstPaperWidth;
            cmbPaperWidth.DataBind();


            var lstPaperHeight = _paperHeightFactory.GetAll();
            cmbPaperHeight.DataSource = lstPaperHeight;
            cmbPaperHeight.DataBind();

            var lstInstitute = _instituteFactory.GetAll();
            cmbFromInstitute.DataSource = lstInstitute;
            cmbFromInstitute.DataBind();

        }
        private void BindGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstPrinting = _printingsFactory.GetAllForGrid(jobId);
            grdviewPrinting.DataSource = lstPrinting;
            grdviewPrinting.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            int jobId = int.Parse(Request.QueryString["JId"]);

            if (!string.IsNullOrEmpty(txtLargePaperCount.Text))
            {
                int fromInstitute = int.Parse(cmbFromInstitute.SelectedValue);
                int materialTypeId = int.Parse(cmbMaterialType.SelectedValue);
                int materialTypeGramazhId = int.Parse(cmbMaterialTypeGramazh.SelectedValue);
                int paperWidthId = int.Parse(cmbPaperWidth.SelectedValue);
                int paperHeightId = int.Parse(cmbPaperHeight.SelectedValue);

                var stockFromInstitute = _stockFactory.GetAllByInstitute(fromInstitute, materialTypeId,
                                                                         materialTypeGramazhId,
                                                                         paperWidthId, paperHeightId);

                if (stockFromInstitute.Count > 0)
                {
                    if (stockFromInstitute[0].LeafCount >= int.Parse(txtLargePaperCount.Text))
                    {
                        _usePaper.JobId = int.Parse(Request.QueryString["JId"]);
                        _usePaper.FromInstituteId = fromInstitute;
                        _usePaper.MaterialTypeId = materialTypeId;
                        _usePaper.MaterialTypeGramazhId = materialTypeGramazhId;
                        _usePaper.PaperWidthId = paperWidthId;
                        _usePaper.PaperHeightId = paperHeightId;
                        _usePaper.LeafCount = int.Parse(txtLargePaperCount.Text);
                        _usePaper.Description = "ثبت خودکار";

                        _usePaperFactory.Insert(_usePaper);

                        stockFromInstitute[0].LeafCount -= int.Parse(txtLargePaperCount.Text);
                        _stockFactory.Update(stockFromInstitute[0]);

                        var message = "مصرف کاغذ از مبدا " + cmbOrderReceiver.Text +
                                     " به تعداد " +
                                     txtLargePaperCount.Text + " ایجاد شد. ";
                        WriteOperation(message);



                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "موجودی بنگاه از تعداد برگ انتخاب شده کمتر است.";
                        return;
                    }
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "بنگاه برای مشخصات انتخاب شده موجودی ندارد.";
                    return;
                }
            }

            _printings.JobId = jobId;
            _printings.Row = 0;
            _printings.Printing = int.Parse(cmbPrinting.SelectedValue);
            _printings.Dimension = txtDimension.Text;
            _printings.OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
            _printings.FromInstituteId = int.Parse(cmbFromInstitute.SelectedValue);
            _printings.PrintTypeId = int.Parse(cmbPrintType.SelectedValue);
            _printings.ZinkTypeId = int.Parse(cmbZinkType.SelectedValue);
            _printings.PrintModelId = int.Parse(cmbPrintModel.SelectedValue);
            _printings.MaterialTypeId = int.Parse(cmbMaterialType.SelectedValue);
            _printings.MaterialTypeGramazhId = int.Parse(cmbMaterialTypeGramazh.SelectedValue);
            if (!string.IsNullOrEmpty(txtLargePaperCount.Text))
                _printings.LargePaperCount = int.Parse(txtLargePaperCount.Text);
            _printings.LargePaperSize = txtLargePaperSize.Text;
            if (!string.IsNullOrEmpty(txtPaperParagraphCount.Text))
                _printings.PaperParagraphCount = double.Parse(txtPaperParagraphCount.Text);
            if (!string.IsNullOrEmpty(txtParagraphLeafCount.Text))
                _printings.ParagraphLeafCount = int.Parse(txtParagraphLeafCount.Text);
            if (!string.IsNullOrEmpty(txtPrintingTirazh.Text))
                _printings.PrintingTirazh = int.Parse(txtPrintingTirazh.Text);
            _printings.MainColorCountId = cmbMainColorCount.SelectedValue != "0" ? int.Parse(cmbMainColorCount.SelectedValue) : (int?)null;
            _printings.ExportColorId = int.Parse(cmbExportColor.SelectedValue);
            _printings.SpotColorCountId = cmbSpotColorCount.SelectedValue != "0" ? int.Parse(cmbSpotColorCount.SelectedValue) : (int?)null;
            _printings.SpotColors = txtSpotColors.Text;
            _printings.PrintingSupervision = bool.Parse(cmbPrintingSupervision.SelectedValue);
            _printings.ColorInstance = int.Parse(cmbColorInstance.SelectedValue);
            if (!string.IsNullOrEmpty(txtDeviceCount.Text))
                _printings.DeviceCount = int.Parse(txtDeviceCount.Text);
            if (!string.IsNullOrEmpty(txtFormEvertCount.Text))
                _printings.FormEvertCount = double.Parse(txtFormEvertCount.Text);
            _printings.Description = txtDescription.Text;

            _printings.InvoiceRow = txtInvoiceRow.Text;
            _printings.InvoiceNum = txtInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                _printings.InvoiceCost = decimal.Parse(txtInvoiceCost.Text);
            _printings.IsUse = false;
            _printings.PaperWidthId = int.Parse(cmbPaperWidth.SelectedValue);
            _printings.PaperHeightId = int.Parse(cmbPaperHeight.SelectedValue);
            _printingsFactory.Insert(_printings);

            var message2 = "چاپ با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                        _printings.JobId + " ایجاد گردید";
            WriteOperation(message2);

            ClearFrom();
            BindGrid();
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "اطلاعات با موفقیت ثبت گردید.";


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeButtonsEnable("Normal");
            ClearFrom();
        }
        protected void LoadEditData_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                ItemId = id;
                ChangeButtonsEnable("Edit");
                var printing = _printingsFactory.GetAllBy(Printings.PrintingsFields.Id, id)[0];
                var usePaper = _usePaperFactory.GetAllBy(UsePaper.UsePaperFields.JobId, printing.JobId);
                if (usePaper.Count > 0)
                {
                    cmbFromInstitute.Enabled = false;
                    cmbMaterialType.Enabled = false;
                    cmbMaterialTypeGramazh.Enabled = false;
                    cmbPaperWidth.Enabled = false;
                    cmbPaperHeight.Enabled = false;
                    txtLargePaperCount.Enabled = false;
                }
                else
                {
                    cmbFromInstitute.Enabled = true;
                    cmbMaterialType.Enabled = true;
                    cmbMaterialTypeGramazh.Enabled = true;
                    cmbPaperWidth.Enabled = true;
                    cmbPaperHeight.Enabled = true;
                    txtLargePaperCount.Enabled = true;
                }

                txtDimension.Text = printing.Dimension;
                cmbPrinting.SelectedValue = printing.Printing.ToString();
                cmbOrderReceiver.SelectedValue = printing.OrderReceiverId.ToString();
                cmbFromInstitute.SelectedValue = printing.FromInstituteId.ToString();
                cmbPrintType.SelectedValue = printing.PrintTypeId.ToString();
                cmbZinkType.SelectedValue = printing.ZinkTypeId.ToString();
                cmbPrintModel.SelectedValue = printing.PrintModelId.ToString();
                cmbMaterialType.SelectedValue = printing.MaterialTypeId.ToString();
                cmbMaterialTypeGramazh.SelectedValue = printing.MaterialTypeGramazhId.ToString();
                txtLargePaperCount.Text = printing.LargePaperCount.ToString();
                txtLargePaperSize.Text = printing.LargePaperSize;
                txtPaperParagraphCount.Text = printing.PaperParagraphCount.ToString();
                txtParagraphLeafCount.Text = printing.ParagraphLeafCount.ToString();
                txtPrintingTirazh.Text = printing.PrintingTirazh.ToString();
                if (printing.IsUse.Value)
                    txtPrintingTirazh.Enabled = false;
                cmbMainColorCount.SelectedValue = printing.MainColorCountId == null ? "0" : printing.MainColorCountId.ToString();
                cmbExportColor.SelectedValue = printing.ExportColorId.ToString();
                cmbSpotColorCount.SelectedValue = printing.SpotColorCountId == null ? "0" : printing.SpotColorCountId.ToString();
                txtSpotColors.Text = printing.SpotColors;
                cmbPrintingSupervision.SelectedValue = printing.PrintingSupervision ? "true" : "false";
                cmbColorInstance.SelectedValue = printing.ColorInstance.ToString();
                txtDeviceCount.Text = printing.DeviceCount.ToString();
                txtFormEvertCount.Text = printing.FormEvertCount.ToString();
                txtDescription.Text = printing.Description;
                txtInvoiceRow.Text = printing.InvoiceRow;
                txtInvoiceNum.Text = printing.InvoiceNum;
                txtInvoiceCost.Text = printing.InvoiceCost.ToString();
                cmbPaperHeight.SelectedValue = printing.PaperHeightId.ToString();
                cmbPaperWidth.SelectedValue = printing.PaperWidthId.ToString();

                CalculateProductCount();
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var lstPrinting = _printingsFactory.GetAllBy(Printings.PrintingsFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                           lstPrinting[0].OrderReceiverId);
                    if (lstPrinting[0].IsUse.Value)
                    {
                        _printingsFactory.UpdateCartexStockSub(id);

                    }
                    var userPaper = _usePaperFactory.GetAllBy(UsePaper.UsePaperFields.JobId, lstPrinting[0].JobId);
                    foreach (var u in userPaper)
                    {
                        var usePaper = _usePaperFactory.GetAllBy(UsePaper.UsePaperFields.Id, u.Id)[0];

                        var stockFromInstitute = _stockFactory.GetAllByInstitute(usePaper.FromInstituteId, usePaper.MaterialTypeId,
                                                                       usePaper.MaterialTypeGramazhId,
                                                                       usePaper.PaperWidthId, usePaper.PaperHeightId);

                        stockFromInstitute[0].LeafCount += usePaper.LeafCount;
                        _stockFactory.Update(stockFromInstitute[0]);

                        _usePaperFactory.Delete(UsePaper.UsePaperFields.Id, u.Id);
                    }
                    _printingsFactory.Delete(Printings.PrintingsFields.Id, id);

                    var message = "چاپ با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                      lstPrinting[0].JobId + " حذف گردید";
                    WriteOperation(message);
                    BindGrid();


                }
                catch (Exception)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }
        private void ClearFrom()
        {
            cmbPrinting.SelectedIndex = 0;
            txtDimension.Text = "";
            cmbOrderReceiver.SelectedIndex = 0;
            cmbFromInstitute.SelectedIndex = 0;
            cmbPrintType.SelectedIndex = 0;
            cmbZinkType.SelectedIndex = 0;
            cmbPrintModel.SelectedIndex = 0;
            cmbMaterialType.SelectedIndex = 0;
            cmbMaterialTypeGramazh.SelectedIndex = 0;
            txtLargePaperCount.Text = "";
            txtLargePaperSize.Text = "";
            txtPaperParagraphCount.Text = "";
            txtParagraphLeafCount.Text = "";
            txtPrintingTirazh.Text = "";
            txtPrintingTirazh.Enabled = true;
            cmbMainColorCount.SelectedIndex = 0;
            cmbExportColor.SelectedIndex = 0;
            cmbSpotColorCount.SelectedIndex = 0;
            txtSpotColors.Text = "";
            cmbPrintingSupervision.SelectedIndex = 0;
            cmbColorInstance.SelectedIndex = 0;
            txtDeviceCount.Text = "";
            txtFormEvertCount.Text = "";
            txtDescription.Text = "";
            txtInvoiceRow.Text = "";
            txtInvoiceNum.Text = "";
            txtInvoiceCost.Text = "";
            cmbPaperHeight.SelectedIndex = 0;
            cmbPaperWidth.SelectedIndex = 0;

            cmbFromInstitute.Enabled = true;
            cmbMaterialType.Enabled = true;
            cmbMaterialTypeGramazh.Enabled = true;
            cmbPaperWidth.Enabled = true;
            cmbPaperHeight.Enabled = true;
            txtLargePaperCount.Enabled = true;
            lblProductCount.Text = "";
        }
        private void ChangeButtonsEnable(string state)
        {
            if (state == "Normal")
            {
                btnSave.Visible = true;
                btnEdit.Visible = false;
                btnCancel.Visible = false;
            }
            else if (state == "Edit")
            {
                btnSave.Visible = false;
                btnEdit.Visible = true;
                btnCancel.Visible = true;
            }

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var lstPrinting = _printingsFactory.GetAllBy(Printings.PrintingsFields.Id, ItemId);
            if (lstPrinting.Count > 0)
            {
                lstPrinting[0].Printing = int.Parse(cmbPrinting.SelectedValue);
                lstPrinting[0].Dimension = txtDimension.Text;
                lstPrinting[0].OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
                lstPrinting[0].FromInstituteId = int.Parse(cmbFromInstitute.SelectedValue);
                lstPrinting[0].PrintTypeId = int.Parse(cmbPrintType.SelectedValue);
                lstPrinting[0].ZinkTypeId = int.Parse(cmbZinkType.SelectedValue);
                lstPrinting[0].PrintModelId = int.Parse(cmbPrintModel.SelectedValue);
                lstPrinting[0].MaterialTypeId = int.Parse(cmbMaterialType.SelectedValue);
                lstPrinting[0].MaterialTypeGramazhId = int.Parse(cmbMaterialTypeGramazh.SelectedValue);
                if (!string.IsNullOrEmpty(txtLargePaperCount.Text))
                {
                    lstPrinting[0].LargePaperCount = int.Parse(txtLargePaperCount.Text);

                }
                else
                {
                    lstPrinting[0].LargePaperCount = null;

                }
                lstPrinting[0].LargePaperSize = txtLargePaperSize.Text;
                if (!string.IsNullOrEmpty(txtPaperParagraphCount.Text))
                {
                    lstPrinting[0].PaperParagraphCount = double.Parse(txtPaperParagraphCount.Text);

                }
                else
                {
                    lstPrinting[0].PaperParagraphCount = null;

                }
                if (!string.IsNullOrEmpty(txtParagraphLeafCount.Text))
                {
                    lstPrinting[0].ParagraphLeafCount = int.Parse(txtParagraphLeafCount.Text);


                }
                else
                {
                    lstPrinting[0].ParagraphLeafCount = null;


                }
                if (!string.IsNullOrEmpty(txtPrintingTirazh.Text))
                {
                    lstPrinting[0].PrintingTirazh = int.Parse(txtPrintingTirazh.Text);


                }
                else
                {
                    lstPrinting[0].PrintingTirazh = null;


                }

                lstPrinting[0].MainColorCountId = cmbMainColorCount.SelectedValue != "0" ? int.Parse(cmbMainColorCount.SelectedValue) : (int?)null;
                lstPrinting[0].ExportColorId = int.Parse(cmbExportColor.SelectedValue);
                lstPrinting[0].SpotColorCountId = cmbSpotColorCount.SelectedValue != "0" ? int.Parse(cmbSpotColorCount.SelectedValue) : (int?)null;
                lstPrinting[0].SpotColors = txtSpotColors.Text;
                lstPrinting[0].PrintingSupervision = bool.Parse(cmbPrintingSupervision.SelectedValue);
                lstPrinting[0].ColorInstance = int.Parse(cmbColorInstance.SelectedValue);
                if (!string.IsNullOrEmpty(txtDeviceCount.Text))
                {
                    lstPrinting[0].DeviceCount = int.Parse(txtDeviceCount.Text);


                }
                else
                {
                    lstPrinting[0].DeviceCount = null;


                }
                if (!string.IsNullOrEmpty(txtFormEvertCount.Text))
                {
                    lstPrinting[0].FormEvertCount = double.Parse(txtFormEvertCount.Text);


                }
                else
                {
                    lstPrinting[0].FormEvertCount = null;


                }
                lstPrinting[0].Description = txtDescription.Text;
                lstPrinting[0].InvoiceRow = txtInvoiceRow.Text;
                lstPrinting[0].InvoiceNum = txtInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                {
                    lstPrinting[0].InvoiceCost = decimal.Parse(txtInvoiceCost.Text);


                }
                else
                {
                    lstPrinting[0].InvoiceCost = null;


                }
                lstPrinting[0].PaperWidthId = int.Parse(cmbPaperWidth.SelectedValue);
                lstPrinting[0].PaperHeightId = int.Parse(cmbPaperHeight.SelectedValue);
                _printingsFactory.Update(lstPrinting[0]);

                var message = "چاپ با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                       lstPrinting[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewPrinting_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewPrinting.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("JobManagement.aspx?Index=" + Request.QueryString["Index"]);
        }

        private void WriteOperation(string Message)
        {
            var operationHistory = new OperationHistories();
            var operationHistoryFactory = new OperationHistoriesFactory();

            operationHistory.UserId = PrintingProject.Session.UserId;
            operationHistory.Date = DateTime.Now;
            operationHistory.Description = Message;

            operationHistoryFactory.Insert(operationHistory);

        }

        protected void grdviewPrinting_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var imageButton = e.Row.FindControl("SendToCartex") as ImageButton;
                if (imageButton != null)
                {
                    int id = int.Parse(imageButton.CssClass);
                    var result = _printingsFactory.IsSend(id);
                    if (result)
                    {
                        imageButton.Visible = false;
                    }

                }

                var imageButtonInsertUsePaper = e.Row.FindControl("InsertUsePaper") as ImageButton;
                if (imageButtonInsertUsePaper != null)
                {
                    int id = int.Parse(imageButtonInsertUsePaper.CssClass);
                    var jobId = _printingsFactory.GetAllBy(Printings.PrintingsFields.Id, id)[0].JobId;
                    var result = _usePaperFactory.GetAllBy(UsePaper.UsePaperFields.JobId, jobId);

                    if (result.Count > 0)
                    {
                        imageButtonInsertUsePaper.Visible = false;
                    }

                }
            }
        }

        protected void SendToCartex_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                var hasCartex = _printingsFactory.HasCartex(id);
                if (hasCartex)
                {

                    _printingsFactory.UpdateCartexStock(id);
                    BindGrid();

                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "کارتکس موجود نیست.";
                }
            }

        }

        protected void InsertUsePaper_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                var printing = _printingsFactory.GetAllBy(Printings.PrintingsFields.Id, id)[0];

                if (printing.LargePaperCount != null)
                {
                    int fromInstitute = printing.FromInstituteId;
                    int materialTypeId = printing.MaterialTypeId;
                    int materialTypeGramazhId = printing.MaterialTypeGramazhId;
                    int paperWidthId = printing.PaperWidthId;
                    int paperHeightId = printing.PaperHeightId;

                    var stockFromInstitute = _stockFactory.GetAllByInstitute(fromInstitute, materialTypeId,
                                                                             materialTypeGramazhId,
                                                                             paperWidthId, paperHeightId);

                    if (stockFromInstitute.Count > 0)
                    {
                        if (stockFromInstitute[0].LeafCount >= printing.LargePaperCount)
                        {
                            _usePaper.JobId = int.Parse(Request.QueryString["JId"]);
                            _usePaper.FromInstituteId = fromInstitute;
                            _usePaper.MaterialTypeId = materialTypeId;
                            _usePaper.MaterialTypeGramazhId = materialTypeGramazhId;
                            _usePaper.PaperWidthId = paperWidthId;
                            _usePaper.PaperHeightId = paperHeightId;
                            _usePaper.LeafCount = printing.LargePaperCount.Value;
                            _usePaper.Description = "ثبت خودکار";

                            _usePaperFactory.Insert(_usePaper);

                            stockFromInstitute[0].LeafCount -= int.Parse(txtLargePaperCount.Text);
                            _stockFactory.Update(stockFromInstitute[0]);

                            BindGrid();

                        }
                        else
                        {
                            lblMessage.ForeColor = Color.Red;
                            lblMessage.Text = "موجودی بنگاه از تعداد برگ انتخاب شده کمتر است.";
                        }
                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "بنگاه برای مشخصات انتخاب شده موجودی ندارد.";
                    }
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "تعداد ورق بزرگ مصرفی وارد نشده است.";
                }
            }

        }

        protected void txtPrintingTirazh_TextChanged(object sender, EventArgs e)
        {
            CalculateProductCount();
            txtLargePaperCount.Focus();

        }

        private void CalculateProductCount()
        {
            string[] code = lblJobCode.Text.Split('#');
            if (code.Length > 0 && code[0] != "" && !string.IsNullOrEmpty(txtPrintingTirazh.Text))
            {
                lblProductCount.Text = (int.Parse(txtPrintingTirazh.Text) * double.Parse(code[1])).ToString();

            }
            else
                lblProductCount.Text = "";
           
        }
    }
}