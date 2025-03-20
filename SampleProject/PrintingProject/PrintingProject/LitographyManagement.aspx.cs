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
    public partial class LitographyManagement : System.Web.UI.Page
    {
        public int PlateItemId { get { return (int)ViewState["PlateItemId"]; } set { ViewState["PlateItemId"] = value; } }
        public int FilmItemId { get { return (int)ViewState["FilmItemId"]; } set { ViewState["FilmItemId"] = value; } }
        public int CopyZinkItemId { get { return (int)ViewState["CopyZinkItemId"]; } set { ViewState["CopyZinkItemId"] = value; } }
        public int StereotypeItemId { get { return (int)ViewState["StereotypeItemId"]; } set { ViewState["StereotypeItemId"] = value; } }
        public int RePrintItemId { get { return (int)ViewState["RePrintItemId"]; } set { ViewState["RePrintItemId"] = value; } }

        Plates _plates = new Plates();
        PlatesFactory _platesFactory = new PlatesFactory();

        Films _films = new Films();
        FilmsFactory _filmsFactory = new FilmsFactory();

        CopyZinks _copyZinks = new CopyZinks();
        CopyZinksFactory _copyZinksFactory = new CopyZinksFactory();

        Stereotypes _stereotypes = new Stereotypes();
        StereotypesFactory _stereotypesFactory = new StereotypesFactory();

        RePrint _rePrint = new RePrint();
        RePrintFactory _rePrintFactory = new RePrintFactory();

        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        DimensionsFactory _dimensionsFactory = new DimensionsFactory();
        LPIFactory _lpiFactory = new LPIFactory();

        MainColorCount _mainColorCount = new MainColorCount();
        MainColorCountFactory _mainColorCountFactory = new MainColorCountFactory();

        ExportColorsFactory _exportColorsFactory = new ExportColorsFactory();
        StereotypeUsagesFactory _stereotypeUsagesFactory = new StereotypeUsagesFactory();
        UserPageFactory _userPageFactory = new UserPageFactory();
        JobsFactory _jobsFactory = new JobsFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "LitographyManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }
                BindCmb();

                BindPlateGrid();
                BindFilmGrid();
                BindCopyZinkGrid();
                BindStereotypeGrid();
                BindRePrintGrid();

                ChangePlateButtonsEnable("Normal");
                ChangeFilmButtonsEnable("Normal");
                ChangeCopyZinkButtonsEnable("Normal");
                ChangeStereotypeButtonsEnable("Normal");
                ChangeRePrintButtonsEnable("Normal");

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
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(1);
            cmbPlateOrderReceiver.DataSource = lstOrderReceiver;
            cmbPlateOrderReceiver.DataBind();

            cmbFilmOrderReceiver.DataSource = lstOrderReceiver;
            cmbFilmOrderReceiver.DataBind();

            cmbCopyZinkOrderReceiver.DataSource = lstOrderReceiver;
            cmbCopyZinkOrderReceiver.DataBind();

            cmbStereotypeOrderReceiver.DataSource = lstOrderReceiver;
            cmbStereotypeOrderReceiver.DataBind();
            //------------------------------------
            var lstDimension = _dimensionsFactory.GetAll();
            cmbPlateDimension.DataSource = lstDimension;
            cmbPlateDimension.DataBind();

            cmbCopyZinkDimension.DataSource = lstDimension;
            cmbCopyZinkDimension.DataBind();
            //------------------------------------
            var lstLpi = _lpiFactory.GetAll();
            cmbPlateLPI.DataSource = lstLpi;
            cmbPlateLPI.DataBind();

            cmbFilmLPI.DataSource = lstLpi;
            cmbFilmLPI.DataBind();

            cmbCopyZinkLPI.DataSource = lstLpi;
            cmbCopyZinkLPI.DataBind();
            //------------------------------------
            var lstMainColorCount = _mainColorCountFactory.GetAll();
            _mainColorCount.Id = 0;
            _mainColorCount.Name = "ندارد";
            lstMainColorCount.Insert(0, _mainColorCount);

            cmbPlateMainColorCount.DataSource = lstMainColorCount;
            cmbPlateMainColorCount.DataBind();

            cmbPlateSpotColorCount.DataSource = lstMainColorCount;
            cmbPlateSpotColorCount.DataBind();

            cmbFilmMainColorCount.DataSource = lstMainColorCount;
            cmbFilmMainColorCount.DataBind();

            cmbFilmSpotColorCount.DataSource = lstMainColorCount;
            cmbFilmSpotColorCount.DataBind();

            cmbCopyZinkMainColorCount.DataSource = lstMainColorCount;
            cmbCopyZinkMainColorCount.DataBind();

            cmbCopyZinkSpotColorCount.DataSource = lstMainColorCount;
            cmbCopyZinkSpotColorCount.DataBind();
            //------------------------------------
            var lstExportColor = _exportColorsFactory.GetAll();
            cmbPlateExportColor.DataSource = lstExportColor;
            cmbPlateExportColor.DataBind();

            cmbFilmExportColor.DataSource = lstExportColor;
            cmbFilmExportColor.DataBind();

            cmbCopyZinkExportColor.DataSource = lstExportColor;
            cmbCopyZinkExportColor.DataBind();
            //------------------------------------
            var lstStereotypeUsage = _stereotypeUsagesFactory.GetAll();
            cmbStereotypeUsages.DataSource = lstStereotypeUsage;
            cmbStereotypeUsages.DataBind();
        }
        #region Plate
        private void BindPlateGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstPlate = _platesFactory.GetAllForGrid(jobId);
            grdviewPlate.DataSource = lstPlate;
            grdviewPlate.DataBind();
        }
        protected void btnPlateSave_Click(object sender, EventArgs e)
        {

            _plates.JobId = int.Parse(Request.QueryString["JId"]);
            _plates.OrderReceiverId = int.Parse(cmbPlateOrderReceiver.SelectedValue);
            _plates.DimensionId = int.Parse(cmbPlateDimension.SelectedValue);
            _plates.LpiId = int.Parse(cmbPlateLPI.SelectedValue);
            _plates.MainColorCountId = cmbPlateMainColorCount.SelectedValue != "0" ? int.Parse(cmbPlateMainColorCount.SelectedValue) : (int?)null;
            _plates.ExportColorId = int.Parse(cmbPlateExportColor.SelectedValue);
            _plates.SpotColorCountId = cmbPlateSpotColorCount.SelectedValue != "0" ? int.Parse(cmbPlateSpotColorCount.SelectedValue) : (int?)null;
            _plates.SpotColors = txtPlateSpotColors.Text;
            _plates.OverPrintBlackColor = bool.Parse(cmbPlateOverPrintBlackColor.SelectedValue);
            if (!string.IsNullOrEmpty(txtPlateDeviceCount.Text))
                _plates.DeviceCount = int.Parse(txtPlateDeviceCount.Text);
            if (!string.IsNullOrEmpty(txtPlateFormEvertCount.Text))
                _plates.FormEvertCount = double.Parse(txtPlateFormEvertCount.Text);
            _plates.Description = txtPlateDescription.Text;

            _plates.InvoiceRow = txtPlateInvoiceRow.Text;
            _plates.InvoiceNum = txtPlateInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtPlateInvoiceCost.Text))
                _plates.InvoiceCost = decimal.Parse(txtPlateInvoiceCost.Text);

            _platesFactory.Insert(_plates);

            var message = "پلیت با سفارش گیرنده " + cmbPlateOrderReceiver.Text + " برای دستور کار با شماره " +
                          _plates.JobId + " ایجاد گردید";
            WriteOperation(message);

            ClearPlateFrom();
            BindPlateGrid();
            lblPlateMessage.ForeColor = Color.Green;
            lblPlateMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
        }
        protected void LoadPlateEditData_Click(object sender, EventArgs e)
        {
            lblPlateMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                PlateItemId = id;
                ChangePlateButtonsEnable("Edit");
                var plate = _platesFactory.GetAllBy(Plates.PlatesFields.Id, id)[0];

                cmbPlateOrderReceiver.SelectedValue = plate.OrderReceiverId.ToString();
                cmbPlateDimension.SelectedValue = plate.DimensionId.ToString();
                cmbPlateLPI.SelectedValue = plate.LpiId.ToString();
                cmbPlateMainColorCount.SelectedValue = plate.MainColorCountId == null ? "0" : plate.MainColorCountId.ToString();
                cmbPlateExportColor.SelectedValue = plate.ExportColorId.ToString();
                cmbPlateSpotColorCount.SelectedValue = plate.SpotColorCountId == null ? "0" : plate.SpotColorCountId.ToString();
                txtPlateSpotColors.Text = plate.SpotColors;
                cmbPlateOverPrintBlackColor.SelectedValue = plate.OverPrintBlackColor ? "true" : "false";
                txtPlateDeviceCount.Text = plate.DeviceCount.ToString();
                txtPlateFormEvertCount.Text = plate.FormEvertCount.ToString();
                txtPlateDescription.Text = plate.Description;
                txtPlateInvoiceRow.Text = plate.InvoiceRow;
                txtPlateInvoiceNum.Text = plate.InvoiceNum;
                txtPlateInvoiceCost.Text = plate.InvoiceCost.ToString();

            }
        }
        protected void btnPlateEdit_Click(object sender, EventArgs e)
        {
            var lstPlate = _platesFactory.GetAllBy(Plates.PlatesFields.Id, PlateItemId);
            if (lstPlate.Count > 0)
            {
                lstPlate[0].OrderReceiverId = int.Parse(cmbPlateOrderReceiver.SelectedValue);
                lstPlate[0].DimensionId = int.Parse(cmbPlateDimension.SelectedValue);
                lstPlate[0].LpiId = int.Parse(cmbPlateLPI.SelectedValue);
                lstPlate[0].MainColorCountId = cmbPlateMainColorCount.SelectedValue != "0" ? int.Parse(cmbPlateMainColorCount.SelectedValue) : (int?)null;
                lstPlate[0].ExportColorId = int.Parse(cmbPlateExportColor.SelectedValue);
                lstPlate[0].SpotColorCountId = cmbPlateSpotColorCount.SelectedValue != "0" ? int.Parse(cmbPlateSpotColorCount.SelectedValue) : (int?)null;
                lstPlate[0].SpotColors = txtPlateSpotColors.Text;
                lstPlate[0].OverPrintBlackColor = bool.Parse(cmbPlateOverPrintBlackColor.SelectedValue);
                if (!string.IsNullOrEmpty(txtPlateDeviceCount.Text))
                {
                    lstPlate[0].DeviceCount = int.Parse(txtPlateDeviceCount.Text);
                }
                else
                {
                    lstPlate[0].DeviceCount = null;
                }
                if (!string.IsNullOrEmpty(txtPlateFormEvertCount.Text))
                {
                    lstPlate[0].FormEvertCount = double.Parse(txtPlateFormEvertCount.Text);
                }
                else
                {
                    lstPlate[0].FormEvertCount = null;
                }
                lstPlate[0].Description = txtPlateDescription.Text;

                lstPlate[0].InvoiceRow = txtPlateInvoiceRow.Text;
                lstPlate[0].InvoiceNum = txtPlateInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtPlateInvoiceCost.Text))
                {
                    lstPlate[0].InvoiceCost = decimal.Parse(txtPlateInvoiceCost.Text);
                }
                else
                {
                    lstPlate[0].InvoiceCost = null;
                }
                _platesFactory.Update(lstPlate[0]);

                var message = "پلیت با سفارش گیرنده " + cmbPlateOrderReceiver.Text + " برای دستور کار با شماره " +
                        lstPlate[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearPlateFrom();
                ChangePlateButtonsEnable("Normal");
                BindPlateGrid();
                lblPlateMessage.ForeColor = Color.Green;
                lblPlateMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }
        protected void PlateDelete_Click(object sender, EventArgs e)
        {
            lblPlateMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var lstPlate = _platesFactory.GetAllBy(Plates.PlatesFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                           lstPlate[0].OrderReceiverId);
                    _platesFactory.Delete(Plates.PlatesFields.Id, id);

                    var message = "پلیت با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                       lstPlate[0].JobId + " حذف گردید";
                    WriteOperation(message);

                    BindPlateGrid();
                }
                catch (Exception)
                {
                    lblPlateMessage.ForeColor = Color.Red;
                    lblPlateMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }

        protected void btnPlateCancel_Click(object sender, EventArgs e)
        {
            ChangePlateButtonsEnable("Normal");
            ClearPlateFrom();
        }
        private void ClearPlateFrom()
        {
            cmbPlateOrderReceiver.SelectedIndex = 0;
            cmbPlateDimension.SelectedIndex = 0;
            cmbPlateLPI.SelectedIndex = 0;
            cmbPlateMainColorCount.SelectedIndex = 0;
            cmbPlateExportColor.SelectedIndex = 0;
            cmbPlateSpotColorCount.SelectedIndex = 0;
            txtPlateSpotColors.Text = "";
            cmbPlateOverPrintBlackColor.SelectedIndex = 0;
            txtPlateDeviceCount.Text = "";
            txtPlateFormEvertCount.Text = "";
            txtPlateDescription.Text = "";
            txtPlateInvoiceRow.Text = "";
            txtPlateInvoiceNum.Text = "";
            txtPlateInvoiceCost.Text = "";
        }
        private void ChangePlateButtonsEnable(string state)
        {
            if (state == "Normal")
            {
                btnPlateSave.Visible = true;
                btnPlateEdit.Visible = false;
                btnPlateCancel.Visible = false;
            }
            else if (state == "Edit")
            {
                btnPlateSave.Visible = false;
                btnPlateEdit.Visible = true;
                btnPlateCancel.Visible = true;
            }

        }
        protected void grdviewPlate_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewPlate.PageIndex = e.NewPageIndex;
            BindPlateGrid();
        }
        #endregion
        #region Film
        private void BindFilmGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstFilm = _filmsFactory.GetAllForGrid(jobId);
            grdviewFilm.DataSource = lstFilm;
            grdviewFilm.DataBind();
        }
        protected void btnFilmSave_Click(object sender, EventArgs e)
        {

            _films.JobId = int.Parse(Request.QueryString["JId"]);
            _films.OrderReceiverId = int.Parse(cmbFilmOrderReceiver.SelectedValue);
            _films.Dimension = txtFilmDimension.Text;
            _films.LpiId = int.Parse(cmbFilmLPI.SelectedValue);
            _films.MainColorCountId = cmbFilmMainColorCount.SelectedValue != "0" ? int.Parse(cmbFilmMainColorCount.SelectedValue) : (int?)null;
            _films.ExportColor = int.Parse(cmbFilmExportColor.SelectedValue);
            _films.SpotColorCountId = cmbFilmSpotColorCount.SelectedValue != "0" ? int.Parse(cmbFilmSpotColorCount.SelectedValue) : (int?)null;
            _films.SpotColors = txtFilmSpotColors.Text;
            _films.OverPrintBlackColor = bool.Parse(cmbFilmOverPrintBlackColor.SelectedValue);
            if (!string.IsNullOrEmpty(txtFilmDeviceCount.Text))
                _films.DeviceCount = int.Parse(txtFilmDeviceCount.Text);
            if (!string.IsNullOrEmpty(txtFilmFormEvertCount.Text))
                _films.FormEvertCount = double.Parse(txtFilmFormEvertCount.Text);
            _films.Film = bool.Parse(cmbFilm.SelectedValue);
            _films.Description = txtFilmDescription.Text;

            _films.InvoiceRow = txtFilmInvoiceRow.Text;
            _films.InvoiceNum = txtFilmInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtFilmInvoiceCost.Text))
                _films.InvoiceCost = decimal.Parse(txtFilmInvoiceCost.Text);

            _filmsFactory.Insert(_films);

            var message = "فیلم با سفارش گیرنده " + cmbFilmOrderReceiver.Text + " برای دستور کار با شماره " +
                      _films.JobId + " ایجاد گردید";
            WriteOperation(message);

            ClearFilmFrom();
            BindFilmGrid();
            lblFilmMessage.ForeColor = Color.Green;
            lblFilmMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
        }
        protected void LoadFilmEditData_Click(object sender, EventArgs e)
        {
            lblFilmMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                FilmItemId = id;
                ChangeFilmButtonsEnable("Edit");
                var film = _filmsFactory.GetAllBy(Films.FilmsFields.Id, id)[0];

                cmbFilmOrderReceiver.SelectedValue = film.OrderReceiverId.ToString();
                txtFilmDimension.Text = film.Dimension;
                cmbFilmLPI.SelectedValue = film.LpiId.ToString();
                cmbFilmMainColorCount.SelectedValue = film.MainColorCountId == null ? "0" : film.MainColorCountId.ToString();
                cmbFilmExportColor.SelectedValue = film.ExportColor.ToString();
                cmbFilmSpotColorCount.SelectedValue = film.SpotColorCountId == null ? "0" : film.SpotColorCountId.ToString();
                txtFilmSpotColors.Text = film.SpotColors;
                cmbFilmOverPrintBlackColor.SelectedValue = film.OverPrintBlackColor ? "true" : "false";
                txtFilmDeviceCount.Text = film.DeviceCount.ToString();
                txtFilmFormEvertCount.Text = film.FormEvertCount.ToString();
                cmbFilm.SelectedValue = film.Film ? "true" : "false";
                txtFilmDescription.Text = film.Description;
                txtFilmInvoiceRow.Text = film.InvoiceRow;
                txtFilmInvoiceNum.Text = film.InvoiceNum;
                txtFilmInvoiceCost.Text = film.InvoiceCost.ToString();

            }
        }
        protected void btnFilmEdit_Click(object sender, EventArgs e)
        {
            var lstFilm = _filmsFactory.GetAllBy(Films.FilmsFields.Id, FilmItemId);
            if (lstFilm.Count > 0)
            {
                lstFilm[0].OrderReceiverId = int.Parse(cmbFilmOrderReceiver.SelectedValue);
                lstFilm[0].Dimension = txtFilmDimension.Text;
                lstFilm[0].LpiId = int.Parse(cmbFilmLPI.SelectedValue);
                lstFilm[0].MainColorCountId = cmbFilmMainColorCount.SelectedValue != "0" ? int.Parse(cmbFilmMainColorCount.SelectedValue) : (int?)null;
                lstFilm[0].ExportColor = int.Parse(cmbFilmExportColor.SelectedValue);
                lstFilm[0].SpotColorCountId = cmbFilmSpotColorCount.SelectedValue != "0" ? int.Parse(cmbFilmSpotColorCount.SelectedValue) : (int?)null;
                lstFilm[0].SpotColors = txtFilmSpotColors.Text;
                lstFilm[0].OverPrintBlackColor = bool.Parse(cmbFilmOverPrintBlackColor.SelectedValue);
                if (!string.IsNullOrEmpty(txtFilmDeviceCount.Text))
                {
                    lstFilm[0].DeviceCount = int.Parse(txtFilmDeviceCount.Text);
                }
                else
                {
                    lstFilm[0].DeviceCount = null;
                }
                if (!string.IsNullOrEmpty(txtFilmFormEvertCount.Text))
                {
                    lstFilm[0].FormEvertCount = double.Parse(txtFilmFormEvertCount.Text);
                }
                else
                {
                    lstFilm[0].FormEvertCount = null;
                }
                lstFilm[0].Film = bool.Parse(cmbFilm.SelectedValue);
                lstFilm[0].Description = txtFilmDescription.Text;

                lstFilm[0].InvoiceRow = txtFilmInvoiceRow.Text;
                lstFilm[0].InvoiceNum = txtFilmInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtFilmInvoiceCost.Text))
                {
                    lstFilm[0].InvoiceCost = decimal.Parse(txtFilmInvoiceCost.Text);
                }
                else
                {
                    lstFilm[0].InvoiceCost = null;
                }

                _filmsFactory.Update(lstFilm[0]);

                var message = "فیلم با سفارش گیرنده " + cmbFilmOrderReceiver.Text + " برای دستور کار با شماره " +
                     lstFilm[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearFilmFrom();
                ChangeFilmButtonsEnable("Normal");
                BindFilmGrid();
                lblFilmMessage.ForeColor = Color.Green;
                lblFilmMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }
        protected void FilmDelete_Click(object sender, EventArgs e)
        {
            lblFilmMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var lstFilm = _filmsFactory.GetAllBy(Films.FilmsFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                           lstFilm[0].OrderReceiverId);
                    _filmsFactory.Delete(Films.FilmsFields.Id, id);

                    var message = "فیلم با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                       lstFilm[0].JobId + " حذف گردید";
                    WriteOperation(message);

                    BindFilmGrid();
                }
                catch (Exception)
                {
                    lblFilmMessage.ForeColor = Color.Red;
                    lblFilmMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }
        protected void btnFilmCancel_Click(object sender, EventArgs e)
        {
            ChangeFilmButtonsEnable("Normal");
            ClearFilmFrom();
        }
        private void ClearFilmFrom()
        {
            cmbFilmOrderReceiver.SelectedIndex = 0;
            txtFilmDimension.Text = "";
            cmbFilmLPI.SelectedIndex = 0;
            cmbFilmMainColorCount.SelectedIndex = 0;
            cmbFilmExportColor.SelectedIndex = 0;
            cmbFilmSpotColorCount.SelectedIndex = 0;
            txtFilmSpotColors.Text = "";
            cmbFilmOverPrintBlackColor.SelectedIndex = 0;
            txtFilmDeviceCount.Text = "";
            txtFilmFormEvertCount.Text = "";
            cmbFilm.SelectedIndex = 0;
            txtFilmDescription.Text = "";
            txtFilmInvoiceRow.Text = "";
            txtFilmInvoiceNum.Text = "";
            txtFilmInvoiceCost.Text = "";

        }
        private void ChangeFilmButtonsEnable(string state)
        {
            if (state == "Normal")
            {
                btnFilmSave.Visible = true;
                btnFilmEdit.Visible = false;
                btnFilmCancel.Visible = false;
            }
            else if (state == "Edit")
            {
                btnFilmSave.Visible = false;
                btnFilmEdit.Visible = true;
                btnFilmCancel.Visible = true;
            }

        }
        protected void grdviewFilm_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewFilm.PageIndex = e.NewPageIndex;
            BindFilmGrid();
        }
        #endregion
        #region CopyZink
        private void BindCopyZinkGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstCopyZink = _copyZinksFactory.GetAllForGrid(jobId);
            grdviewCopyZink.DataSource = lstCopyZink;
            grdviewCopyZink.DataBind();
        }
        protected void btnCopyZinkSave_Click(object sender, EventArgs e)
        {

            _copyZinks.JobId = int.Parse(Request.QueryString["JId"]);
            _copyZinks.OrderReceiverId = int.Parse(cmbCopyZinkOrderReceiver.SelectedValue);
            _copyZinks.DimensionId = int.Parse(cmbCopyZinkDimension.SelectedValue);
            _copyZinks.LpiId = int.Parse(cmbCopyZinkLPI.SelectedValue);
            _copyZinks.MainColorCountId = cmbCopyZinkMainColorCount.SelectedValue != "0" ? int.Parse(cmbCopyZinkMainColorCount.SelectedValue) : (int?)null;
            _copyZinks.ExportColorId = int.Parse(cmbCopyZinkExportColor.SelectedValue);
            _copyZinks.SpotColorCountId = cmbCopyZinkSpotColorCount.SelectedValue != "0" ? int.Parse(cmbCopyZinkSpotColorCount.SelectedValue) : (int?)null;
            _copyZinks.SpotColors = txtCopyZinkSpotColors.Text;
            _copyZinks.OverPrintBlackColor = bool.Parse(cmbCopyZinkOverPrintBlackColor.SelectedValue);
            if (!string.IsNullOrEmpty(txtCopyZinkDeviceCount.Text))
                _copyZinks.DeviceCount = int.Parse(txtCopyZinkDeviceCount.Text);
            if (!string.IsNullOrEmpty(txtCopyZinkFormEvertCount.Text))
                _copyZinks.FormEvertCount = double.Parse(txtCopyZinkFormEvertCount.Text);
            _copyZinks.Description = txtCopyZinkDescription.Text;

            _copyZinks.InvoiceRow = txtCopyZinkInvoiceRow.Text;
            _copyZinks.InvoiceNum = txtCopyZinkInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtCopyZinkInvoiceCost.Text))
                _copyZinks.InvoiceCost = decimal.Parse(txtCopyZinkInvoiceCost.Text);

            _copyZinksFactory.Insert(_copyZinks);

            var message = "کپی زینک با سفارش گیرنده " + cmbCopyZinkOrderReceiver.Text + " برای دستور کار با شماره " +
                      _copyZinks.JobId + " ایجاد گردید";
            WriteOperation(message);

            ClearCopyZinkFrom();
            BindCopyZinkGrid();
            lblCopyZinkMessage.ForeColor = Color.Green;
            lblCopyZinkMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
        }
        protected void LoadCopyZinkEditData_Click(object sender, EventArgs e)
        {
            lblCopyZinkMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                CopyZinkItemId = id;
                ChangeCopyZinkButtonsEnable("Edit");
                var copyZink = _copyZinksFactory.GetAllBy(CopyZinks.CopyZinksFields.Id, id)[0];

                cmbCopyZinkOrderReceiver.SelectedValue = copyZink.OrderReceiverId.ToString();
                cmbCopyZinkDimension.SelectedValue = copyZink.DimensionId.ToString();
                cmbCopyZinkLPI.SelectedValue = copyZink.LpiId.ToString();
                cmbCopyZinkMainColorCount.SelectedValue = copyZink.MainColorCountId == null ? "0" : copyZink.MainColorCountId.ToString();
                cmbCopyZinkExportColor.SelectedValue = copyZink.ExportColorId.ToString();
                cmbCopyZinkSpotColorCount.SelectedValue = copyZink.SpotColorCountId == null ? "0" : copyZink.SpotColorCountId.ToString();
                txtCopyZinkSpotColors.Text = copyZink.SpotColors;
                cmbCopyZinkOverPrintBlackColor.SelectedValue = copyZink.OverPrintBlackColor ? "true" : "false";
                txtCopyZinkDeviceCount.Text = copyZink.DeviceCount.ToString();
                txtCopyZinkFormEvertCount.Text = copyZink.FormEvertCount.ToString();
                txtCopyZinkDescription.Text = copyZink.Description;
                txtCopyZinkInvoiceRow.Text = copyZink.InvoiceRow;
                txtCopyZinkInvoiceNum.Text = copyZink.InvoiceNum;
                txtCopyZinkInvoiceCost.Text = copyZink.InvoiceCost.ToString();

            }
        }
        protected void btnCopyZinkEdit_Click(object sender, EventArgs e)
        {
            var lstCopyZink = _copyZinksFactory.GetAllBy(CopyZinks.CopyZinksFields.Id, CopyZinkItemId);
            if (lstCopyZink.Count > 0)
            {
                lstCopyZink[0].OrderReceiverId = int.Parse(cmbCopyZinkOrderReceiver.SelectedValue);
                lstCopyZink[0].DimensionId = int.Parse(cmbCopyZinkDimension.SelectedValue);
                lstCopyZink[0].LpiId = int.Parse(cmbCopyZinkLPI.SelectedValue);
                lstCopyZink[0].MainColorCountId = cmbCopyZinkMainColorCount.SelectedValue != "0" ? int.Parse(cmbCopyZinkMainColorCount.SelectedValue) : (int?)null;
                lstCopyZink[0].ExportColorId = int.Parse(cmbCopyZinkExportColor.SelectedValue);
                lstCopyZink[0].SpotColorCountId = cmbCopyZinkSpotColorCount.SelectedValue != "0" ? int.Parse(cmbCopyZinkSpotColorCount.SelectedValue) : (int?)null;
                lstCopyZink[0].SpotColors = txtCopyZinkSpotColors.Text;
                lstCopyZink[0].OverPrintBlackColor = bool.Parse(cmbCopyZinkOverPrintBlackColor.SelectedValue);
                if (!string.IsNullOrEmpty(txtCopyZinkDeviceCount.Text))
                {
                    lstCopyZink[0].DeviceCount = int.Parse(txtCopyZinkDeviceCount.Text);
                }
                else
                {
                    lstCopyZink[0].DeviceCount = null;
                }
                if (!string.IsNullOrEmpty(txtCopyZinkFormEvertCount.Text))
                {
                    lstCopyZink[0].FormEvertCount = double.Parse(txtCopyZinkFormEvertCount.Text);
                }
                else
                {
                    lstCopyZink[0].FormEvertCount = null;
                }
                lstCopyZink[0].Description = txtCopyZinkDescription.Text;

                lstCopyZink[0].InvoiceRow = txtCopyZinkInvoiceRow.Text;
                lstCopyZink[0].InvoiceNum = txtCopyZinkInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtCopyZinkInvoiceCost.Text))
                {
                    lstCopyZink[0].InvoiceCost = decimal.Parse(txtCopyZinkInvoiceCost.Text);
                }
                else
                {
                    lstCopyZink[0].InvoiceCost = null;
                }
                _copyZinksFactory.Update(lstCopyZink[0]);

                var message = "کپی زینک با سفارش گیرنده " + cmbCopyZinkOrderReceiver.Text + " برای دستور کار با شماره " +
                     lstCopyZink[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearCopyZinkFrom();
                ChangeCopyZinkButtonsEnable("Normal");
                BindCopyZinkGrid();
                lblCopyZinkMessage.ForeColor = Color.Green;
                lblCopyZinkMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }
        protected void CopyZinkDelete_Click(object sender, EventArgs e)
        {
            lblCopyZinkMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var lstCopyZink = _copyZinksFactory.GetAllBy(CopyZinks.CopyZinksFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                           lstCopyZink[0].OrderReceiverId);

                    _copyZinksFactory.Delete(CopyZinks.CopyZinksFields.Id, id);

                    var message = "کپی زینک با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                     lstCopyZink[0].JobId + " حذف گردید";
                    WriteOperation(message);

                    BindCopyZinkGrid();
                }
                catch (Exception)
                {
                    lblCopyZinkMessage.ForeColor = Color.Red;
                    lblCopyZinkMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }
        protected void btnCopyZinkCancel_Click(object sender, EventArgs e)
        {
            ChangeCopyZinkButtonsEnable("Normal");
            ClearCopyZinkFrom();
        }
        private void ClearCopyZinkFrom()
        {
            cmbCopyZinkOrderReceiver.SelectedIndex = 0;
            cmbCopyZinkDimension.SelectedIndex = 0;
            cmbCopyZinkLPI.SelectedIndex = 0;
            cmbCopyZinkMainColorCount.SelectedIndex = 0;
            cmbCopyZinkExportColor.SelectedIndex = 0;
            cmbCopyZinkSpotColorCount.SelectedIndex = 0;
            txtCopyZinkSpotColors.Text = "";
            cmbCopyZinkOverPrintBlackColor.SelectedIndex = 0;
            txtCopyZinkDeviceCount.Text = "";
            txtCopyZinkFormEvertCount.Text = "";
            txtCopyZinkDescription.Text = "";
            txtCopyZinkInvoiceRow.Text = "";
            txtCopyZinkInvoiceNum.Text = "";
            txtCopyZinkInvoiceCost.Text = "";
        }
        private void ChangeCopyZinkButtonsEnable(string state)
        {
            if (state == "Normal")
            {
                btnCopyZinkSave.Visible = true;
                btnCopyZinkEdit.Visible = false;
                btnCopyZinkCancel.Visible = false;
            }
            else if (state == "Edit")
            {
                btnCopyZinkSave.Visible = false;
                btnCopyZinkEdit.Visible = true;
                btnCopyZinkCancel.Visible = true;
            }

        }
        protected void grdviewCopyZink_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewCopyZink.PageIndex = e.NewPageIndex;
            BindCopyZinkGrid();
        }
        #endregion
        #region Stereotype
        private void BindStereotypeGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstStereotype = _stereotypesFactory.GetAllForGrid(jobId);
            grdviewStereotype.DataSource = lstStereotype;
            grdviewStereotype.DataBind();
        }
        protected void btnStereotypeSave_Click(object sender, EventArgs e)
        {

            _stereotypes.JobId = int.Parse(Request.QueryString["JId"]);
            _stereotypes.OrderReceiverId = int.Parse(cmbStereotypeOrderReceiver.SelectedValue);
            _stereotypes.Dimension = txtStereotypeDimension.Text;
            _stereotypes.Thickness = int.Parse(cmbStereotypeThickness.SelectedValue);
            _stereotypes.Type = int.Parse(cmbStereotypeType.SelectedValue);
            _stereotypes.Stereotype = bool.Parse(cmbStereotype.SelectedValue);
            _stereotypes.StereotypeUsagesId = int.Parse(cmbStereotypeUsages.SelectedValue);
            if (!string.IsNullOrEmpty(txtStereotypeCount.Text))
                _stereotypes.Count = int.Parse(txtStereotypeCount.Text);
            _stereotypes.Description = txtStereotypeDescription.Text;

            _stereotypes.InvoiceRow = txtStereotypeInvoiceRow.Text;
            _stereotypes.InvoiceNum = txtStereotypeInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtStereotypeInvoiceCost.Text))
                _stereotypes.InvoiceCost = decimal.Parse(txtStereotypeInvoiceCost.Text);
            _stereotypesFactory.Insert(_stereotypes);

            var message = " کلیشه با سفارش گیرنده " + cmbStereotypeOrderReceiver.Text + " برای دستور کار با شماره " +
                     _stereotypes.JobId + " ایجاد گردید";
            WriteOperation(message);

            ClearStereotypeFrom();
            BindStereotypeGrid();
            lblStereotypeMessage.ForeColor = Color.Green;
            lblStereotypeMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
        }
        protected void LoadStereotypeEditData_Click(object sender, EventArgs e)
        {
            lblStereotypeMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                StereotypeItemId = id;
                ChangeStereotypeButtonsEnable("Edit");
                var stereotype = _stereotypesFactory.GetAllBy(Stereotypes.StereotypesFields.Id, id)[0];
                cmbStereotypeOrderReceiver.SelectedValue = stereotype.OrderReceiverId.ToString();
                txtStereotypeDimension.Text = stereotype.Dimension;
                cmbStereotypeThickness.SelectedValue = stereotype.Thickness.ToString();
                cmbStereotypeType.SelectedValue = stereotype.Type.ToString();
                cmbStereotype.SelectedValue = stereotype.Stereotype ? "true" : "false";
                cmbStereotypeUsages.SelectedValue = stereotype.StereotypeUsagesId.ToString();
                txtStereotypeCount.Text = stereotype.Count.ToString();
                txtStereotypeDescription.Text = stereotype.Description;
                txtStereotypeInvoiceRow.Text = stereotype.InvoiceRow;
                txtStereotypeInvoiceNum.Text = stereotype.InvoiceNum;
                txtStereotypeInvoiceCost.Text = stereotype.InvoiceCost.ToString();
            }
        }
        protected void btnStereotypeEdit_Click(object sender, EventArgs e)
        {
            var lstStereotype = _stereotypesFactory.GetAllBy(Stereotypes.StereotypesFields.Id, StereotypeItemId);
            if (lstStereotype.Count > 0)
            {
                lstStereotype[0].OrderReceiverId = int.Parse(cmbStereotypeOrderReceiver.SelectedValue);
                lstStereotype[0].Dimension = txtStereotypeDimension.Text;
                lstStereotype[0].Thickness = int.Parse(cmbStereotypeThickness.SelectedValue);
                lstStereotype[0].Type = int.Parse(cmbStereotypeType.SelectedValue);
                lstStereotype[0].Stereotype = bool.Parse(cmbStereotype.SelectedValue);
                lstStereotype[0].StereotypeUsagesId = int.Parse(cmbStereotypeUsages.SelectedValue);
                if (!string.IsNullOrEmpty(txtStereotypeCount.Text))
                {
                    lstStereotype[0].Count = int.Parse(txtStereotypeCount.Text);

                }
                else
                {
                    lstStereotype[0].Count = null;

                }
                lstStereotype[0].Description = txtStereotypeDescription.Text;

                lstStereotype[0].InvoiceRow = txtStereotypeInvoiceRow.Text;
                lstStereotype[0].InvoiceNum = txtStereotypeInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtStereotypeInvoiceCost.Text))
                {
                    lstStereotype[0].InvoiceCost = decimal.Parse(txtStereotypeInvoiceCost.Text);

                }
                else
                {
                    lstStereotype[0].InvoiceCost = null;

                }
                _stereotypesFactory.Update(lstStereotype[0]);

                var message = " کلیشه با سفارش گیرنده " + cmbStereotypeOrderReceiver.Text + " برای دستور کار با شماره " +
                    lstStereotype[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearStereotypeFrom();
                ChangeStereotypeButtonsEnable("Normal");
                BindStereotypeGrid();
                lblStereotypeMessage.ForeColor = Color.Green;
                lblStereotypeMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }
        protected void StereotypeDelete_Click(object sender, EventArgs e)
        {
            lblStereotypeMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var lstStereotype = _stereotypesFactory.GetAllBy(Stereotypes.StereotypesFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                          lstStereotype[0].OrderReceiverId);
                    _stereotypesFactory.Delete(Stereotypes.StereotypesFields.Id, id);

                    var message = " کلیشه با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                                  lstStereotype[0].JobId + " حذف گردید";
                    WriteOperation(message);

                    BindStereotypeGrid();
                }
                catch (Exception)
                {
                    lblStereotypeMessage.ForeColor = Color.Red;
                    lblStereotypeMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }
        protected void btnStereotypeCancel_Click(object sender, EventArgs e)
        {
            ChangeStereotypeButtonsEnable("Normal");
            ClearStereotypeFrom();
        }
        private void ClearStereotypeFrom()
        {
            cmbStereotypeOrderReceiver.SelectedIndex = 0;
            txtStereotypeDimension.Text = "";
            cmbStereotypeThickness.SelectedIndex = 0;
            cmbStereotypeType.SelectedIndex = 0;
            cmbStereotype.SelectedIndex = 0;
            cmbStereotypeUsages.SelectedIndex = 0;
            txtStereotypeCount.Text = "";
            txtStereotypeDescription.Text = "";
            txtStereotypeInvoiceRow.Text = "";
            txtStereotypeInvoiceNum.Text = "";
            txtStereotypeInvoiceCost.Text = "";

        }
        private void ChangeStereotypeButtonsEnable(string state)
        {
            if (state == "Normal")
            {
                btnStereotypeSave.Visible = true;
                btnStereotypeEdit.Visible = false;
                btnStereotypeCancel.Visible = false;
            }
            else if (state == "Edit")
            {
                btnStereotypeSave.Visible = false;
                btnStereotypeEdit.Visible = true;
                btnStereotypeCancel.Visible = true;
            }

        }
        protected void grdviewStereotype_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewStereotype.PageIndex = e.NewPageIndex;
            BindStereotypeGrid();
        }
        #endregion
        #region RePrint
        private void BindRePrintGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstReprint = _rePrintFactory.GetAllBy(RePrint.RePrintFields.JobId, jobId);
            grdviewRePrint.DataSource = lstReprint;
            grdviewRePrint.DataBind();
        }
        protected void btnRePrintSave_Click(object sender, EventArgs e)
        {

            _rePrint.JobId = int.Parse(Request.QueryString["JId"]);
            _rePrint.CreateDate = DateTime.Now;
            _rePrint.Description = txtRePrintDescription.Text;

            _rePrintFactory.Insert(_rePrint);

            var message = "تجدید چاپ برای دستور کار با شماره " + _rePrint.JobId + " ایجاد گردید";
            WriteOperation(message);

            ClearRePrintFrom();
            BindRePrintGrid();
            lblRePrintMessage.ForeColor = Color.Green;
            lblRePrintMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
        }
        protected void LoadRePrintEditData_Click(object sender, EventArgs e)
        {
            lblRePrintMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                RePrintItemId = id;
                ChangeRePrintButtonsEnable("Edit");
                var rePrint = _rePrintFactory.GetAllBy(RePrint.RePrintFields.Id, id)[0];
                txtRePrintDescription.Text = rePrint.Description;

            }
        }
        protected void btnRePrintEdit_Click(object sender, EventArgs e)
        {
            var lstRePrint = _rePrintFactory.GetAllBy(RePrint.RePrintFields.Id, RePrintItemId);
            if (lstRePrint.Count > 0)
            {

                lstRePrint[0].Description = txtRePrintDescription.Text;

                _rePrintFactory.Update(lstRePrint[0]);

                var message = "تجدید چاپ برای دستور کار با شماره " + lstRePrint[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearRePrintFrom();
                ChangeRePrintButtonsEnable("Normal");
                BindRePrintGrid();
                lblRePrintMessage.ForeColor = Color.Green;
                lblRePrintMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }
        protected void RePrintDelete_Click(object sender, EventArgs e)
        {
            lblRePrintMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var lstRePrint = _rePrintFactory.GetAllBy(RePrint.RePrintFields.Id, id);
                    _rePrintFactory.Delete(RePrint.RePrintFields.Id, id);

                    var message = "تجدید چاپ برای دستور کار با شماره " + lstRePrint[0].JobId + " حذف گردید";
                    WriteOperation(message);

                    BindRePrintGrid();
                }
                catch (Exception)
                {
                    lblStereotypeMessage.ForeColor = Color.Red;
                    lblStereotypeMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }
        protected void btnRePrintCancel_Click(object sender, EventArgs e)
        {
            ChangeRePrintButtonsEnable("Normal");
            ClearRePrintFrom();
        }
        private void ClearRePrintFrom()
        {
            txtRePrintDescription.Text = "";
        }
        private void ChangeRePrintButtonsEnable(string state)
        {
            if (state == "Normal")
            {
                btnRePrintSave.Visible = true;
                btnRePrintEdit.Visible = false;
                btnRePrintCancel.Visible = false;
            }
            else if (state == "Edit")
            {
                btnRePrintSave.Visible = false;
                btnRePrintEdit.Visible = true;
                btnRePrintCancel.Visible = true;
            }

        }
        protected void grdviewRePrint_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewRePrint.PageIndex = e.NewPageIndex;
            BindRePrintGrid();
        }
        #endregion

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

    }
}