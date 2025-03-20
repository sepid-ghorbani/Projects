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
    public partial class PaperManagement : System.Web.UI.Page
    {
        public int BuyPaperItemId { get { return (int)ViewState["BuyPaperItemId"]; } set { ViewState["BuyPaperItemId"] = value; } }

        BuyPaper _buyPaper = new BuyPaper();
        BuyPaperFactory _buyPaperFactory = new BuyPaperFactory();

        PreparingPaper _preparingPaper = new PreparingPaper();
        PreparingPaperFactory _preparingPaperFactory = new PreparingPaperFactory();

        UsePaper _usePaper = new UsePaper();
        UsePaperFactory _usePaperFactory = new UsePaperFactory();

        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        MaterialTypesFactory _materialTypesFactory = new MaterialTypesFactory();
        MaterialTypeGramazhFactory _materialTypeGramazhFactory = new MaterialTypeGramazhFactory();
        PaperWidthFactory _paperWidthFactory = new PaperWidthFactory();
        PaperHeightFactory _paperHeightFactory = new PaperHeightFactory();
        LeafCountFactory _leafCountFactory = new LeafCountFactory();
        InstituteFactory _instituteFactory = new InstituteFactory();

        Stock _stock = new Stock();
        StockFactory _stockFactory = new StockFactory();

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
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "PaperManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }
                BindCmb();
                BindBuyPaperGrid();
                BindPreparingPaperGrid();
                BindUsePaperGrid();

                ChangeBuyPaperButtonsEnable("Normal");

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
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(3);
            cmbBuyPaperOrderReceiver.DataSource = lstOrderReceiver;
            cmbBuyPaperOrderReceiver.DataBind();

            //------------------------------------
            var lstMaterialType = _materialTypesFactory.GetAll();
            cmbBuyPaperMaterialType.DataSource = lstMaterialType;
            cmbBuyPaperMaterialType.DataBind();

            cmbPreparingPaperMaterialType.DataSource = lstMaterialType;
            cmbPreparingPaperMaterialType.DataBind();

            cmbUsePaperMaterialType.DataSource = lstMaterialType;
            cmbUsePaperMaterialType.DataBind();
            //------------------------------------
            var lstMaterialTypeGramazh = _materialTypeGramazhFactory.GetAll();
            cmbBuyPaperMaterialTypeGramazh.DataSource = lstMaterialTypeGramazh;
            cmbBuyPaperMaterialTypeGramazh.DataBind();

            cmbPreparingPaperMaterialTypeGramazh.DataSource = lstMaterialTypeGramazh;
            cmbPreparingPaperMaterialTypeGramazh.DataBind();

            cmbUsePaperMaterialTypeGramazh.DataSource = lstMaterialTypeGramazh;
            cmbUsePaperMaterialTypeGramazh.DataBind();

            //------------------------------------
            var lstPaperWidth = _paperWidthFactory.GetAll();
            cmbBuyPaperPaperWidth.DataSource = lstPaperWidth;
            cmbBuyPaperPaperWidth.DataBind();

            cmbPreparingPaperPaperWidth.DataSource = lstPaperWidth;
            cmbPreparingPaperPaperWidth.DataBind();

            cmbUsePaperPaperWidth.DataSource = lstPaperWidth;
            cmbUsePaperPaperWidth.DataBind();

            //------------------------------------
            var lstPaperHeight = _paperHeightFactory.GetAll();
            cmbBuyPaperPaperHeight.DataSource = lstPaperHeight;
            cmbBuyPaperPaperHeight.DataBind();

            cmbPreparingPaperPaperHeight.DataSource = lstPaperHeight;
            cmbPreparingPaperPaperHeight.DataBind();

            cmbUsePaperPaperHeight.DataSource = lstPaperHeight;
            cmbUsePaperPaperHeight.DataBind();
            //------------------------------------
            var lstLeafCount = _leafCountFactory.GetAll();
            cmbBuyPaperLeafCount.DataSource = lstLeafCount;
            cmbBuyPaperLeafCount.DataBind();

            //------------------------------------
            var lstInstitute = _instituteFactory.GetAll();
            cmbBuyPaperInstitute.DataSource = lstInstitute;
            cmbBuyPaperInstitute.DataBind();

            cmbPreparingPaperFromInstitute.DataSource = lstInstitute;
            cmbPreparingPaperFromInstitute.DataBind();

            cmbPreparingPaperToInstitute.DataSource = lstInstitute;
            cmbPreparingPaperToInstitute.DataBind();

            cmbUsePaperFromInstitute.DataSource = lstInstitute;
            cmbUsePaperFromInstitute.DataBind();

        }
        #region BuyPaper
        private void BindBuyPaperGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstBuyPaper = _buyPaperFactory.GetAllForGrid(jobId);
            grdviewBuyPaper.DataSource = lstBuyPaper;
            grdviewBuyPaper.DataBind();
        }
        private void CalculateSumCost()
        {
            var sumCostType = cmbBuyPaperSumCost.SelectedValue;

            double sumCost = 0;
            switch (sumCostType)
            {
                case "1":
                    {
                        double c = cmbBuyPaperMaterialTypeGramazh.Text == "0" ? 1 : double.Parse(cmbBuyPaperMaterialTypeGramazh.Text);
                        double d = double.Parse(cmbBuyPaperPaperWidth.Text);
                        double e = double.Parse(cmbBuyPaperPaperHeight.Text);
                        double f = double.Parse(!string.IsNullOrEmpty(txtBuyPaperParagraphCount.Text) ? txtBuyPaperParagraphCount.Text : "1");
                        double g = double.Parse(cmbBuyPaperLeafCount.Text);
                        double h = double.Parse(!string.IsNullOrEmpty(txtBuyPaperFee.Text) ? txtBuyPaperFee.Text : "1");

                        sumCost = (c * d * e * f * g * h) / 10000000;
                        break;
                    }
                case "2":
                    {
                        double f = double.Parse(!string.IsNullOrEmpty(txtBuyPaperParagraphCount.Text) ? txtBuyPaperParagraphCount.Text : "1");
                        double h = double.Parse(!string.IsNullOrEmpty(txtBuyPaperFee.Text) ? txtBuyPaperFee.Text : "1");

                        sumCost = (f * h);
                        break;
                    }
                case "3":
                    {
                        double f = double.Parse(!string.IsNullOrEmpty(txtBuyPaperParagraphCount.Text) ? txtBuyPaperParagraphCount.Text : "1");
                        double g = double.Parse(cmbBuyPaperLeafCount.Text);
                        double h = double.Parse(!string.IsNullOrEmpty(txtBuyPaperFee.Text) ? txtBuyPaperFee.Text : "1");

                        sumCost = (f * g * h);
                        break;

                    }

            }
            lblBuyPaperSumCost.Text = string.Format("{0:#,###0}", sumCost);
        }

        protected void btnBuyPaperSave_Click(object sender, EventArgs e)
        {
            CalculateSumCost();
            _buyPaper.JobId = int.Parse(Request.QueryString["JId"]);
            _buyPaper.OrderReceiverId = int.Parse(cmbBuyPaperOrderReceiver.SelectedValue);
            _buyPaper.Row = 0;
            _buyPaper.MaterialTypeId = int.Parse(cmbBuyPaperMaterialType.SelectedValue);
            _buyPaper.MaterialTypeGramazhId = int.Parse(cmbBuyPaperMaterialTypeGramazh.SelectedValue);
            _buyPaper.PaperWidthId = int.Parse(cmbBuyPaperPaperWidth.SelectedValue);
            _buyPaper.PaperHeightId = int.Parse(cmbBuyPaperPaperHeight.SelectedValue);
            if (!string.IsNullOrEmpty(txtBuyPaperParagraphCount.Text))
                _buyPaper.ParagraphCount = int.Parse(txtBuyPaperParagraphCount.Text);
            _buyPaper.LeafCountId = int.Parse(cmbBuyPaperLeafCount.SelectedValue);
            if (!string.IsNullOrEmpty(txtBuyPaperFee.Text))
                _buyPaper.Fee = decimal.Parse(txtBuyPaperFee.Text);

            _buyPaper.SumCostType = int.Parse(cmbBuyPaperSumCost.SelectedValue);
            _buyPaper.SumCost = decimal.Parse(lblBuyPaperSumCost.Text);
            _buyPaper.InstituteId = int.Parse(cmbBuyPaperInstitute.SelectedValue);
            _buyPaper.InvoiceRow = txtBuyPaperInvoiceRow.Text;
            _buyPaper.InvoiceNum = txtBuyPaperInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtBuyPaperInvoiceCost.Text))
                _buyPaper.InvoiceCost = decimal.Parse(txtBuyPaperInvoiceCost.Text);
            _buyPaper.Description = txtBuyPaperDescription.Text;
            _buyPaperFactory.Insert(_buyPaper);

            var stockInstitute = _stockFactory.GetAllByInstitute(_buyPaper.InstituteId, _buyPaper.MaterialTypeId,
                                                                 _buyPaper.MaterialTypeGramazhId,
                                                                 _buyPaper.PaperWidthId, _buyPaper.PaperHeightId);

            int f = int.Parse(!string.IsNullOrEmpty(txtBuyPaperParagraphCount.Text) ? txtBuyPaperParagraphCount.Text : "1");
            int g = int.Parse(cmbBuyPaperLeafCount.Text);
            if (stockInstitute.Count > 0)
            {
                stockInstitute[0].LeafCount += (f * g);
                _stockFactory.Update(stockInstitute[0]);
            }
            else
            {
                _stock.InstituteId = _buyPaper.InstituteId;
                _stock.MaterialTypeId = _buyPaper.MaterialTypeId;
                _stock.MaterialTypeGramazhId = _buyPaper.MaterialTypeGramazhId;
                _stock.PaperWidthId = _buyPaper.PaperWidthId;
                _stock.PaperHeightId = _buyPaper.PaperHeightId;
                _stock.LeafCount = (f * g);
                _stockFactory.Insert(_stock);
            }


            var message = "خرید کاغذ با سفارش گیرنده " + cmbBuyPaperOrderReceiver.Text + " برای دستور کار با شماره " +
                        _buyPaper.JobId + " ایجاد گردید";
            WriteOperation(message);

            ClearBuyPaperFrom();
            BindBuyPaperGrid();
            lblBuyPaperMessage.ForeColor = Color.Green;
            lblBuyPaperMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
        }
        protected void LoadBuyPaperEditData_Click(object sender, EventArgs e)
        {
            lblBuyPaperMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                BuyPaperItemId = id;
                ChangeBuyPaperButtonsEnable("Edit");
                var buyPaper = _buyPaperFactory.GetAllBy(BuyPaper.BuyPaperFields.Id, id)[0];

                cmbBuyPaperOrderReceiver.SelectedValue = buyPaper.OrderReceiverId.ToString();
                cmbBuyPaperMaterialType.SelectedValue = buyPaper.MaterialTypeId.ToString();
                cmbBuyPaperMaterialTypeGramazh.SelectedValue = buyPaper.MaterialTypeGramazhId.ToString();
                cmbBuyPaperPaperWidth.SelectedValue = buyPaper.PaperWidthId.ToString();
                cmbBuyPaperPaperHeight.SelectedValue = buyPaper.PaperHeightId.ToString();
                txtBuyPaperParagraphCount.Text = buyPaper.ParagraphCount.ToString();
                cmbBuyPaperLeafCount.SelectedValue = buyPaper.LeafCountId.ToString();
                txtBuyPaperFee.Text = buyPaper.Fee.ToString();
                cmbBuyPaperSumCost.SelectedValue = buyPaper.SumCostType.ToString();
                lblBuyPaperSumCost.Text = string.Format("{0:#,###0}", buyPaper.SumCost);
                cmbBuyPaperInstitute.SelectedValue = buyPaper.InstituteId.ToString();
                txtBuyPaperInvoiceRow.Text = buyPaper.InvoiceRow;
                txtBuyPaperInvoiceNum.Text = buyPaper.InvoiceNum;
                txtBuyPaperInvoiceCost.Text = buyPaper.InvoiceCost.ToString();
                txtBuyPaperDescription.Text = buyPaper.Description;

                txtBuyPaperParagraphCount.Enabled = false;
                cmbBuyPaperLeafCount.Enabled = false;
                cmbBuyPaperInstitute.Enabled = false;
                cmbBuyPaperMaterialType.Enabled = false;
                cmbBuyPaperMaterialTypeGramazh.Enabled = false;
                cmbBuyPaperPaperWidth.Enabled = false;
                cmbBuyPaperPaperHeight.Enabled = false;

            }
        }
        protected void btnBuyPaperEdit_Click(object sender, EventArgs e)
        {
            var lstBuyPaper = _buyPaperFactory.GetAllBy(BuyPaper.BuyPaperFields.Id, BuyPaperItemId);
            if (lstBuyPaper.Count > 0)
            {
                CalculateSumCost();


                lstBuyPaper[0].OrderReceiverId = int.Parse(cmbBuyPaperOrderReceiver.SelectedValue);
                lstBuyPaper[0].MaterialTypeId = int.Parse(cmbBuyPaperMaterialType.SelectedValue);
                lstBuyPaper[0].MaterialTypeGramazhId = int.Parse(cmbBuyPaperMaterialTypeGramazh.SelectedValue);
                lstBuyPaper[0].PaperWidthId = int.Parse(cmbBuyPaperPaperWidth.SelectedValue);
                lstBuyPaper[0].PaperHeightId = int.Parse(cmbBuyPaperPaperHeight.SelectedValue);
                if (!string.IsNullOrEmpty(txtBuyPaperParagraphCount.Text))
                {
                    lstBuyPaper[0].ParagraphCount = int.Parse(txtBuyPaperParagraphCount.Text);
                }
                else
                {
                    lstBuyPaper[0].ParagraphCount = null;
                }

                lstBuyPaper[0].LeafCountId = int.Parse(cmbBuyPaperLeafCount.SelectedValue);
                if (!string.IsNullOrEmpty(txtBuyPaperFee.Text))
                {
                    lstBuyPaper[0].Fee = int.Parse(txtBuyPaperFee.Text);
                }
                else
                {
                    lstBuyPaper[0].Fee = null;
                }

                lstBuyPaper[0].SumCostType = int.Parse(cmbBuyPaperSumCost.SelectedValue);
                lstBuyPaper[0].SumCost = decimal.Parse(lblBuyPaperSumCost.Text);
                lstBuyPaper[0].InstituteId = int.Parse(cmbBuyPaperInstitute.SelectedValue);

                lstBuyPaper[0].InvoiceRow = txtBuyPaperInvoiceRow.Text;
                lstBuyPaper[0].InvoiceNum = txtBuyPaperInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtBuyPaperInvoiceCost.Text))
                {
                    lstBuyPaper[0].InvoiceCost = decimal.Parse(txtBuyPaperInvoiceCost.Text);
                }
                else
                {
                    lstBuyPaper[0].InvoiceCost = null;
                }

                lstBuyPaper[0].Description = txtBuyPaperDescription.Text;

                _buyPaperFactory.Update(lstBuyPaper[0]);

                var message = "خرید کاغذ با سفارش گیرنده " + cmbBuyPaperOrderReceiver.Text + " برای دستور کار با شماره " +
                       lstBuyPaper[0].JobId + " ویرایش گردید";
                WriteOperation(message);


                txtBuyPaperParagraphCount.Enabled = true;
                cmbBuyPaperLeafCount.Enabled = true;
                cmbBuyPaperInstitute.Enabled = true;
                cmbBuyPaperMaterialType.Enabled = true;
                cmbBuyPaperMaterialTypeGramazh.Enabled = true;
                cmbBuyPaperPaperWidth.Enabled = true;
                cmbBuyPaperPaperHeight.Enabled = true;

                ClearBuyPaperFrom();
                ChangeBuyPaperButtonsEnable("Normal");
                BindBuyPaperGrid();
                lblBuyPaperMessage.ForeColor = Color.Green;
                lblBuyPaperMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }
        protected void BuyPaperDelete_Click(object sender, EventArgs e)
        {
            lblBuyPaperMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var lstBuyPaper = _buyPaperFactory.GetAllBy(BuyPaper.BuyPaperFields.Id, id)[0];
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                           lstBuyPaper.OrderReceiverId);
                    var stockInstitute = _stockFactory.GetAllByInstitute(lstBuyPaper.InstituteId, lstBuyPaper.MaterialTypeId,
                                                               lstBuyPaper.MaterialTypeGramazhId,
                                                               lstBuyPaper.PaperWidthId, lstBuyPaper.PaperHeightId);

                    if (stockInstitute.Count > 0)
                    {
                        var leafCount = _leafCountFactory.GetAllBy(LeafCount.LeafCountFields.Id, lstBuyPaper.LeafCountId)[0];
                        stockInstitute[0].LeafCount -= ((lstBuyPaper.ParagraphCount ?? 1) * int.Parse(leafCount.Name));

                        if (stockInstitute[0].LeafCount >= 0)
                        {
                            _stockFactory.Update(stockInstitute[0]);

                            _buyPaperFactory.Delete(BuyPaper.BuyPaperFields.Id, id);

                            var message = "خرید کاغذ با سفارش گیرنده " + lstOrderReceiver[0].Name +
                                          " برای دستور کار با شماره " +
                                          lstBuyPaper.JobId + " حذف گردید";
                            WriteOperation(message);

                            BindBuyPaperGrid();

                        }
                        else
                        {
                            lblBuyPaperMessage.ForeColor = Color.Red;
                            lblBuyPaperMessage.Text = "بدلیل کافی نبودن موجودی بنگاه شما قادر به حذف این خرید نیستید.";
                        }

                    }
                    else
                    {
                        lblBuyPaperMessage.ForeColor = Color.Red;
                        lblBuyPaperMessage.Text = "موجودی یافت نشد.";
                    }

                }
                catch (Exception)
                {
                    lblBuyPaperMessage.ForeColor = Color.Red;
                    lblBuyPaperMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }
        protected void btnBuyPaperCancel_Click(object sender, EventArgs e)
        {
            txtBuyPaperParagraphCount.Enabled = true;
            cmbBuyPaperLeafCount.Enabled = true;
            cmbBuyPaperInstitute.Enabled = true;
            cmbBuyPaperMaterialType.Enabled = true;
            cmbBuyPaperMaterialTypeGramazh.Enabled = true;
            cmbBuyPaperPaperWidth.Enabled = true;
            cmbBuyPaperPaperHeight.Enabled = true;
            ChangeBuyPaperButtonsEnable("Normal");
            ClearBuyPaperFrom();
        }
        private void ClearBuyPaperFrom()
        {
            cmbBuyPaperOrderReceiver.SelectedIndex = 0;
            cmbBuyPaperMaterialType.SelectedIndex = 0;
            cmbBuyPaperMaterialTypeGramazh.SelectedIndex = 0;
            cmbBuyPaperPaperWidth.SelectedIndex = 0;
            cmbBuyPaperPaperHeight.SelectedIndex = 0;
            txtBuyPaperParagraphCount.Text = "";
            cmbBuyPaperLeafCount.SelectedIndex = 0;
            txtBuyPaperFee.Text = "";
            cmbBuyPaperSumCost.SelectedIndex = 0;
            lblBuyPaperSumCost.Text = "";
            cmbBuyPaperInstitute.SelectedIndex = 0;
            txtBuyPaperInvoiceRow.Text = "";
            txtBuyPaperInvoiceNum.Text = "";
            txtBuyPaperInvoiceCost.Text = "";
            txtBuyPaperDescription.Text = "";

        }
        private void ChangeBuyPaperButtonsEnable(string state)
        {
            if (state == "Normal")
            {
                btnBuyPaperSave.Visible = true;
                btnBuyPaperEdit.Visible = false;
                btnBuyPaperCancel.Visible = false;
            }
            else if (state == "Edit")
            {
                btnBuyPaperSave.Visible = false;
                btnBuyPaperEdit.Visible = true;
                btnBuyPaperCancel.Visible = true;
            }

        }
        protected void grdviewBuyPaper_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewBuyPaper.PageIndex = e.NewPageIndex;
            BindBuyPaperGrid();
        }
        protected void cmbBuyPaperMaterialTypeGramazh_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            CalculateSumCost();
            cmbBuyPaperPaperWidth.Focus();
        }

        protected void cmbBuyPaperPaperWidth_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            CalculateSumCost();
            cmbBuyPaperPaperHeight.Focus();
        }

        protected void cmbBuyPaperPaperHeight_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            CalculateSumCost();
            txtBuyPaperParagraphCount.Focus();
        }

        protected void txtBuyPaperParagraphCount_TextChanged(object sender, EventArgs e)
        {
            CalculateSumCost();
            cmbBuyPaperLeafCount.Focus();
        }

        protected void cmbBuyPaperLeafCount_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            CalculateSumCost();
            txtBuyPaperFee.Focus();
        }

        protected void txtBuyPaperFee_TextChanged(object sender, EventArgs e)
        {
            CalculateSumCost();
            cmbBuyPaperSumCost.Focus();
        }

        protected void cmbBuyPaperSumCost_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            CalculateSumCost();
        }
        #endregion
        #region PreparingPaper
        private void BindPreparingPaperGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstPreparingPaper = _preparingPaperFactory.GetAllForGrid(jobId);
            grdviewPreparingPaper.DataSource = lstPreparingPaper;
            grdviewPreparingPaper.DataBind();
        }
        protected void btnPreparingPaperSave_Click(object sender, EventArgs e)
        {
            int fromInstitute = int.Parse(cmbPreparingPaperFromInstitute.SelectedValue);
            int toInstitute = int.Parse(cmbPreparingPaperToInstitute.SelectedValue);
            int materialTypeId = int.Parse(cmbPreparingPaperMaterialType.SelectedValue);
            int materialTypeGramazhId = int.Parse(cmbPreparingPaperMaterialTypeGramazh.SelectedValue);
            int paperWidthId = int.Parse(cmbPreparingPaperPaperWidth.SelectedValue);
            int paperHeightId = int.Parse(cmbPreparingPaperPaperHeight.SelectedValue);

            var stockFromInstitute = _stockFactory.GetAllByInstitute(fromInstitute, materialTypeId,
                                                              materialTypeGramazhId,
                                                              paperWidthId, paperHeightId);
            var stockToInstitute = _stockFactory.GetAllByInstitute(toInstitute, materialTypeId,
                                                              materialTypeGramazhId,
                                                              paperWidthId, paperHeightId);

            if (stockFromInstitute.Count > 0)
            {
                if (stockFromInstitute[0].LeafCount >= int.Parse(txtPreparingPaperLeafCount.Text))
                {
                    _preparingPaper.JobId = int.Parse(Request.QueryString["JId"]);
                    _preparingPaper.FromInstituteId = fromInstitute;
                    _preparingPaper.ToInstituteId = toInstitute;
                    _preparingPaper.MaterialTypeId = materialTypeId;
                    _preparingPaper.MaterialTypeGramazhId = materialTypeGramazhId;
                    _preparingPaper.PaperWidthId = paperWidthId;
                    _preparingPaper.PaperHeightId = paperHeightId;
                    _preparingPaper.LeafCount = int.Parse(txtPreparingPaperLeafCount.Text);
                    _preparingPaper.Description = txtPreparingPaperDescription.Text;

                    _preparingPaperFactory.Insert(_preparingPaper);

                    stockFromInstitute[0].LeafCount -= _preparingPaper.LeafCount;
                    _stockFactory.Update(stockFromInstitute[0]);
                    if (stockToInstitute.Count > 0)
                    {
                        stockToInstitute[0].LeafCount += _preparingPaper.LeafCount;
                        _stockFactory.Update(stockToInstitute[0]);
                    }
                    else
                    {
                        _stock.InstituteId = toInstitute;
                        _stock.MaterialTypeId = materialTypeId;
                        _stock.MaterialTypeGramazhId = materialTypeGramazhId;
                        _stock.PaperWidthId = paperWidthId;
                        _stock.PaperHeightId = paperHeightId;
                        _stock.LeafCount = _preparingPaper.LeafCount;

                        _stockFactory.Insert(_stock);

                    }

                    var message = "تامین کاغذ از مبدا " + cmbPreparingPaperFromInstitute.Text +
                                  " به مقصد " + cmbPreparingPaperToInstitute.Text + " به تعداد " +
                                  txtPreparingPaperLeafCount.Text + " ایجاد شد. ";
                    WriteOperation(message);

                    ClearPreparingPaperFrom();
                    BindPreparingPaperGrid();
                    lblPreparingPaperMessage.ForeColor = Color.Green;
                    lblPreparingPaperMessage.Text = "اطلاعات با موفقیت ثبت گردید.";

                }
                else
                {
                    lblPreparingPaperMessage.ForeColor = Color.Red;
                    lblPreparingPaperMessage.Text = "موجودی بنگاه مقصد از تعداد برگ انتخاب شده کمتر است.";
                }
            }
            else
            {
                lblPreparingPaperMessage.ForeColor = Color.Red;
                lblPreparingPaperMessage.Text = "بنگاه مقصد برای مشخصات انتخاب شده موجودی ندارد.";
            }

        }
        protected void PreparingPaperDelete_Click(object sender, EventArgs e)
        {
            lblPreparingPaperMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var preparingPaper = _preparingPaperFactory.GetAllBy(PreparingPaper.PreparingPaperFields.Id, id)[0];
                    var fromInstitute = _instituteFactory.GetAllBy(Institute.InstituteFields.Id, preparingPaper.FromInstituteId);
                    var toInstitute = _instituteFactory.GetAllBy(Institute.InstituteFields.Id, preparingPaper.ToInstituteId);

                    var stockFromInstitute = _stockFactory.GetAllByInstitute(preparingPaper.FromInstituteId, preparingPaper.MaterialTypeId,
                                                             preparingPaper.MaterialTypeGramazhId,
                                                             preparingPaper.PaperWidthId, preparingPaper.PaperHeightId)[0];

                    var stockToInstitute = _stockFactory.GetAllByInstitute(preparingPaper.ToInstituteId, preparingPaper.MaterialTypeId,
                                                             preparingPaper.MaterialTypeGramazhId,
                                                             preparingPaper.PaperWidthId, preparingPaper.PaperHeightId)[0];


                    if (preparingPaper.LeafCount > stockToInstitute.LeafCount)
                    {
                        lblPreparingPaperMessage.ForeColor = Color.Red;
                        lblPreparingPaperMessage.Text = "موجودی مقصد برای انجام عملیات کافی نمی باشد.";
                    }
                    else
                    {

                        stockFromInstitute.LeafCount += preparingPaper.LeafCount;
                        stockToInstitute.LeafCount -= preparingPaper.LeafCount;

                        _stockFactory.Update(stockFromInstitute);
                        _stockFactory.Update(stockToInstitute);

                        _preparingPaperFactory.Delete(PreparingPaper.PreparingPaperFields.Id, id);

                        var message = "تامین کاغذ از مبدا " + fromInstitute[0].Name +
                                 " به مقصد " + toInstitute[0].Name + " به تعداد " +
                                 preparingPaper.LeafCount + " حذف شد. ";
                        WriteOperation(message);

                        BindPreparingPaperGrid();
                    }

                }
                catch (Exception)
                {
                    lblPreparingPaperMessage.ForeColor = Color.Red;
                    lblPreparingPaperMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }

        private void ClearPreparingPaperFrom()
        {
            cmbPreparingPaperFromInstitute.SelectedIndex = 0;
            cmbPreparingPaperToInstitute.SelectedIndex = 0;
            cmbPreparingPaperMaterialType.SelectedIndex = 0;
            cmbPreparingPaperMaterialTypeGramazh.SelectedIndex = 0;
            cmbPreparingPaperPaperWidth.SelectedIndex = 0;
            cmbPreparingPaperPaperHeight.SelectedIndex = 0;
            txtPreparingPaperLeafCount.Text = "";
            txtPreparingPaperDescription.Text = "";
        }

        protected void grdviewPreparingPaper_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewPreparingPaper.PageIndex = e.NewPageIndex;
            BindPreparingPaperGrid();
        }
        #endregion
        #region UsePaper
        private void BindUsePaperGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstUsePaper = _usePaperFactory.GetAllForGrid(jobId);
            grdviewUsePaper.DataSource = lstUsePaper;
            grdviewUsePaper.DataBind();
        }
        protected void btnUsePaperSave_Click(object sender, EventArgs e)
        {
            int fromInstitute = int.Parse(cmbUsePaperFromInstitute.SelectedValue);
            int materialTypeId = int.Parse(cmbUsePaperMaterialType.SelectedValue);
            int materialTypeGramazhId = int.Parse(cmbUsePaperMaterialTypeGramazh.SelectedValue);
            int paperWidthId = int.Parse(cmbUsePaperPaperWidth.SelectedValue);
            int paperHeightId = int.Parse(cmbUsePaperPaperHeight.SelectedValue);

            var stockFromInstitute = _stockFactory.GetAllByInstitute(fromInstitute, materialTypeId,
                                                                     materialTypeGramazhId,
                                                                     paperWidthId, paperHeightId);

            if (stockFromInstitute.Count > 0)
            {
                if (stockFromInstitute[0].LeafCount >= int.Parse(txtUsePaperLeafCount.Text))
                {
                    _usePaper.JobId = int.Parse(Request.QueryString["JId"]);
                    _usePaper.FromInstituteId = fromInstitute;
                    _usePaper.MaterialTypeId = materialTypeId;
                    _usePaper.MaterialTypeGramazhId = materialTypeGramazhId;
                    _usePaper.PaperWidthId = paperWidthId;
                    _usePaper.PaperHeightId = paperHeightId;
                    _usePaper.LeafCount = int.Parse(txtUsePaperLeafCount.Text);
                    _usePaper.Description = txtUsePaperDescription.Text;

                    _usePaperFactory.Insert(_usePaper);

                    stockFromInstitute[0].LeafCount -= int.Parse(txtUsePaperLeafCount.Text);
                    _stockFactory.Update(stockFromInstitute[0]);

                    var message = "مصرف کاغذ از مبدا " + cmbUsePaperFromInstitute.Text +
                                 " به تعداد " +
                                 txtUsePaperLeafCount.Text + " ایجاد شد. ";
                    WriteOperation(message);

                    ClearUsePaperFrom();
                    BindUsePaperGrid();
                    lblUsePaperMessage.ForeColor = Color.Green;
                    lblUsePaperMessage.Text = "اطلاعات با موفقیت ثبت گردید.";

                }
                else
                {
                    lblUsePaperMessage.ForeColor = Color.Red;
                    lblUsePaperMessage.Text = "موجودی بنگاه از تعداد برگ انتخاب شده کمتر است.";
                }
            }
            else
            {
                lblUsePaperMessage.ForeColor = Color.Red;
                lblUsePaperMessage.Text = "بنگاه برای مشخصات انتخاب شده موجودی ندارد.";
            }

        }

        protected void UsePaperDelete_Click(object sender, EventArgs e)
        {
            lblUsePaperMessage.Text = "";
            var btn = sender as ImageButton;
            if (btn != null)
            {
                try
                {
                    int id = int.Parse(btn.CssClass);
                    var usePaper = _usePaperFactory.GetAllBy(UsePaper.UsePaperFields.Id, id)[0];
                    var fromInstitute = _instituteFactory.GetAllBy(Institute.InstituteFields.Id, usePaper.FromInstituteId);

                    var stockFromInstitute = _stockFactory.GetAllByInstitute(usePaper.FromInstituteId, usePaper.MaterialTypeId,
                                                                   usePaper.MaterialTypeGramazhId,
                                                                   usePaper.PaperWidthId, usePaper.PaperHeightId);

                    stockFromInstitute[0].LeafCount += usePaper.LeafCount;
                    _stockFactory.Update(stockFromInstitute[0]);

                    _usePaperFactory.Delete(UsePaper.UsePaperFields.Id, id);

                    var message = "مصرف کاغذ از مبدا " + fromInstitute[0].Name +
                                " به تعداد " +
                                usePaper.LeafCount + " حذف شد. ";
                    WriteOperation(message);

                    BindUsePaperGrid();
                }
                catch (Exception)
                {
                    lblUsePaperMessage.ForeColor = Color.Red;
                    lblUsePaperMessage.Text = "از این اطلاعات در سیستم استفاده شده است.";
                }
            }

        }

        private void ClearUsePaperFrom()
        {
            cmbUsePaperFromInstitute.SelectedIndex = 0;
            cmbUsePaperMaterialType.SelectedIndex = 0;
            cmbUsePaperMaterialTypeGramazh.SelectedIndex = 0;
            cmbUsePaperPaperWidth.SelectedIndex = 0;
            cmbUsePaperPaperHeight.SelectedIndex = 0;
            txtUsePaperLeafCount.Text = "";
            txtUsePaperDescription.Text = "";
        }

        protected void grdviewUsePaper_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewUsePaper.PageIndex = e.NewPageIndex;
            BindUsePaperGrid();
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