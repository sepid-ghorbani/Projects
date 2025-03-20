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
    public partial class FinalInvoiceManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        FinalInvoice _finalInvoice = new FinalInvoice();
        FinalInvoiceFactory _finalInvoiceFactory = new FinalInvoiceFactory();

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
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "FinalInvoiceManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }
                FillForm();
                CheckHasFactor();
                CalculateSum();

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

        private void FillForm()
        {
            HyperLink1.Visible = false;

            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstFinalInvoice = _finalInvoiceFactory.GetAllBy(FinalInvoice.FinalInvoiceFields.JobId, jobId);
            if (lstFinalInvoice.Count > 0)
            {
                chkHasntFactor.Checked = !lstFinalInvoice[0].HasInvoice;
                txtPlateCost.Text = lstFinalInvoice[0].PlateCost.ToString();
                txtFilmCost.Text = lstFinalInvoice[0].FilmCost.ToString();
                txtCopyZinkCost.Text = lstFinalInvoice[0].FilmCost.ToString();
                txtStereotypeCost.Text = lstFinalInvoice[0].StereotypeCost.ToString();
                txtPrintingCost.Text = lstFinalInvoice[0].PrintingCost.ToString();
                txtBuyPaperCost.Text = lstFinalInvoice[0].BuyPaperCost.ToString();
                txtVeneerCost.Text = lstFinalInvoice[0].VeneerCost.ToString();
                txtLetterPressCost.Text = lstFinalInvoice[0].LetterPressCost.ToString();
                txtMakingTemplateCost.Text = lstFinalInvoice[0].MakingTemplateCost.ToString();
                txtSahafiCost.Text = lstFinalInvoice[0].SahafiCost.ToString();
                txtSumOutputCosts.Text = lstFinalInvoice[0].SumAll.ToString();
                txtDescription.Text = lstFinalInvoice[0].Description;

                HyperLink1.Visible = true;
                HyperLink1.NavigateUrl = "PrintPreviewPage.aspx?FinalInvoiceId=" + lstFinalInvoice[0].Id;
            }

            var dt = _finalInvoiceFactory.GetInputCosts(jobId);
            if (dt.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dt.Rows[0]["PlateInputCost"].ToString()) && !dt.Rows[0]["PlateInputCost"].ToString().Contains("ن"))
                {
                    lblPlateCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["PlateInputCost"].ToString()));
                }
                else
                {
                    lblPlateCost.Text = dt.Rows[0]["PlateInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["FilmInputCost"].ToString()) && !dt.Rows[0]["FilmInputCost"].ToString().Contains("ن"))
                {
                    lblFilmCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["FilmInputCost"].ToString()));
                }
                else
                {
                    lblFilmCost.Text = dt.Rows[0]["FilmInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["CopyZinkInputCost"].ToString()) && !dt.Rows[0]["CopyZinkInputCost"].ToString().Contains("ن"))
                {
                    lblCopyZink.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["CopyZinkInputCost"].ToString()));
                }
                else
                {
                    lblCopyZink.Text = dt.Rows[0]["CopyZinkInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["StereotypeInputCost"].ToString()) && !dt.Rows[0]["StereotypeInputCost"].ToString().Contains("ن"))
                {
                    lblStereotypeCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["StereotypeInputCost"].ToString()));
                }
                else
                {
                    lblStereotypeCost.Text = dt.Rows[0]["StereotypeInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["PrintingInputCost"].ToString()) && !dt.Rows[0]["PrintingInputCost"].ToString().Contains("ن"))
                {
                    lblPrintingCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["PrintingInputCost"].ToString()));
                }
                else
                {
                    lblPrintingCost.Text = dt.Rows[0]["PrintingInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["BuyPaperInputCost"].ToString()) && !dt.Rows[0]["BuyPaperInputCost"].ToString().Contains("ن"))
                {
                    lblBuyPaperCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["BuyPaperInputCost"].ToString()));
                }
                else
                {
                    lblBuyPaperCost.Text = dt.Rows[0]["BuyPaperInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["VeneerInputCost"].ToString()) && !dt.Rows[0]["VeneerInputCost"].ToString().Contains("ن"))
                {
                    lblVeneerCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["VeneerInputCost"].ToString()));
                }
                else
                {
                    lblVeneerCost.Text = dt.Rows[0]["VeneerInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["LetterPressInputCost"].ToString()) && !dt.Rows[0]["LetterPressInputCost"].ToString().Contains("ن"))
                {
                    lblLetterPressCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["LetterPressInputCost"].ToString()));
                }
                else
                {
                    lblLetterPressCost.Text = dt.Rows[0]["LetterPressInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["MakingTemplateInputCost"].ToString()) && !dt.Rows[0]["MakingTemplateInputCost"].ToString().Contains("ن"))
                {
                    lblMakingTemplateCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["MakingTemplateInputCost"].ToString()));
                }
                else
                {
                    lblMakingTemplateCost.Text = dt.Rows[0]["MakingTemplateInputCost"].ToString();
                }
                if (!string.IsNullOrEmpty(dt.Rows[0]["SahafiInputCost"].ToString()) && !dt.Rows[0]["SahafiInputCost"].ToString().Contains("ن"))
                {
                    lblSahafiCost.Text = string.Format("{0:#,###0}", decimal.Parse(dt.Rows[0]["SahafiInputCost"].ToString()));
                }
                else
                {
                    lblSahafiCost.Text = dt.Rows[0]["SahafiInputCost"].ToString();
                }

                var sumall = decimal.Parse(!string.IsNullOrEmpty(lblPlateCost.Text) && !lblPlateCost.Text.Contains("ن") ? lblPlateCost.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblFilmCost.Text) && !lblFilmCost.Text.Contains("ن") ? lblFilmCost.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblCopyZink.Text) && !lblCopyZink.Text.Contains("ن") ? lblCopyZink.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblStereotypeCost.Text) && !lblStereotypeCost.Text.Contains("ن") ? lblStereotypeCost.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblPrintingCost.Text) && !lblPrintingCost.Text.Contains("ن") ? lblPrintingCost.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblBuyPaperCost.Text) && !lblBuyPaperCost.Text.Contains("ن") ? lblBuyPaperCost.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblVeneerCost.Text) && !lblVeneerCost.Text.Contains("ن") ? lblVeneerCost.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblLetterPressCost.Text) && !lblLetterPressCost.Text.Contains("ن") ? lblLetterPressCost.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblMakingTemplateCost.Text) && !lblMakingTemplateCost.Text.Contains("ن") ? lblMakingTemplateCost.Text : "0") +
                             decimal.Parse(!string.IsNullOrEmpty(lblSahafiCost.Text) && !lblSahafiCost.Text.Contains("ن") ? lblSahafiCost.Text : "0");

                lblSumInputCosts.Text = string.Format("{0:#,###0}", sumall);
            }

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            int jobId = int.Parse(Request.QueryString["JId"]);

            var lstFinalInvoice = _finalInvoiceFactory.GetAllBy(FinalInvoice.FinalInvoiceFields.JobId, jobId);
            if (lstFinalInvoice.Count > 0)
            {


                lstFinalInvoice[0].HasInvoice = !chkHasntFactor.Checked;
                lstFinalInvoice[0].PlateCost = decimal.Parse(txtPlateCost.Text);
                lstFinalInvoice[0].FilmCost = decimal.Parse(txtFilmCost.Text);
                lstFinalInvoice[0].CopyZinkCost = decimal.Parse(txtCopyZinkCost.Text);
                lstFinalInvoice[0].StereotypeCost = decimal.Parse(txtStereotypeCost.Text);
                lstFinalInvoice[0].PrintingCost = decimal.Parse(txtPrintingCost.Text);
                lstFinalInvoice[0].BuyPaperCost = decimal.Parse(txtBuyPaperCost.Text);
                lstFinalInvoice[0].VeneerCost = decimal.Parse(txtVeneerCost.Text);
                lstFinalInvoice[0].LetterPressCost = decimal.Parse(txtLetterPressCost.Text);
                lstFinalInvoice[0].MakingTemplateCost = decimal.Parse(txtMakingTemplateCost.Text);
                lstFinalInvoice[0].SahafiCost = decimal.Parse(txtSahafiCost.Text);
                lstFinalInvoice[0].SumAll = decimal.Parse(txtSumOutputCosts.Text);
                lstFinalInvoice[0].Description = txtDescription.Text;



                _finalInvoiceFactory.Update(lstFinalInvoice[0]);

                var message = "فاکتور نهایی برای دستور کار با شماره " + lstFinalInvoice[0].JobId + " ویرایش گردید.";
                WriteOperation(message);
            }
            else
            {


                _finalInvoice.JobId = jobId;
                _finalInvoice.HasInvoice = !chkHasntFactor.Checked;
                _finalInvoice.PlateCost = decimal.Parse(txtPlateCost.Text);
                _finalInvoice.FilmCost = decimal.Parse(txtFilmCost.Text);
                _finalInvoice.CopyZinkCost = decimal.Parse(txtCopyZinkCost.Text);
                _finalInvoice.StereotypeCost = decimal.Parse(txtStereotypeCost.Text);
                _finalInvoice.PrintingCost = decimal.Parse(txtPrintingCost.Text);
                _finalInvoice.BuyPaperCost = decimal.Parse(txtBuyPaperCost.Text);
                _finalInvoice.VeneerCost = decimal.Parse(txtVeneerCost.Text);
                _finalInvoice.LetterPressCost = decimal.Parse(txtLetterPressCost.Text);
                _finalInvoice.MakingTemplateCost = decimal.Parse(txtMakingTemplateCost.Text);
                _finalInvoice.SahafiCost = decimal.Parse(txtSahafiCost.Text);
                _finalInvoice.SumAll = decimal.Parse(txtSumOutputCosts.Text);
                _finalInvoice.Description = txtDescription.Text;



                _finalInvoiceFactory.Insert(_finalInvoice);

                var message = "فاکتور نهایی برای دستور کار با شماره " + _finalInvoice.JobId + " ایجاد گردید.";
                WriteOperation(message);

            }
            FillForm();
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
        }

        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("JobManagement.aspx?Index=" + Request.QueryString["Index"]);
        }

        protected void chkHasntFactor_CheckedChanged(object sender, EventArgs e)
        {
            CheckHasFactor();
        }

        private void CheckHasFactor()
        {
            if (chkHasntFactor.Checked)
            {
                txtPlateCost.Text = "0";
                txtFilmCost.Text = "0";
                txtCopyZinkCost.Text = "0";
                txtStereotypeCost.Text = "0";
                txtPrintingCost.Text = "0";
                txtBuyPaperCost.Text = "0";
                txtVeneerCost.Text = "0";
                txtLetterPressCost.Text = "0";
                txtMakingTemplateCost.Text = "0";
                txtSahafiCost.Text = "0";
                txtSumOutputCosts.Text = "0";

                txtPlateCost.Enabled = false;
                txtFilmCost.Enabled = false;
                txtCopyZinkCost.Enabled = false;
                txtStereotypeCost.Enabled = false;
                txtPrintingCost.Enabled = false;
                txtBuyPaperCost.Enabled = false;
                txtVeneerCost.Enabled = false;
                txtLetterPressCost.Enabled = false;
                txtMakingTemplateCost.Enabled = false;
                txtSahafiCost.Enabled = false;
                txtSumOutputCosts.Enabled = false;
            }
            else
            {
                txtPlateCost.Enabled = true;
                txtFilmCost.Enabled = true;
                txtCopyZinkCost.Enabled = true;
                txtStereotypeCost.Enabled = true;
                txtPrintingCost.Enabled = true;
                txtBuyPaperCost.Enabled = true;
                txtVeneerCost.Enabled = true;
                txtLetterPressCost.Enabled = true;
                txtMakingTemplateCost.Enabled = true;
                txtSahafiCost.Enabled = true;
                txtSumOutputCosts.Enabled = true;
            }
        }

        private void CalculateSum()
        {
            decimal sum = decimal.Parse(!string.IsNullOrEmpty(txtPlateCost.Text) ? txtPlateCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtFilmCost.Text) ? txtFilmCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtCopyZinkCost.Text) ? txtCopyZinkCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtStereotypeCost.Text) ? txtStereotypeCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtPrintingCost.Text) ? txtPrintingCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtBuyPaperCost.Text) ? txtBuyPaperCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtVeneerCost.Text) ? txtVeneerCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtLetterPressCost.Text) ? txtLetterPressCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtMakingTemplateCost.Text) ? txtMakingTemplateCost.Text : "0") +
                          decimal.Parse(!string.IsNullOrEmpty(txtSahafiCost.Text) ? txtSahafiCost.Text : "0");
            lblSumOutputCosts.Text = string.Format("{0:#,###0}", sum);
        }

        protected void txtPlateCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtFilmCost.Focus();
        }

        protected void txtFilmCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtCopyZinkCost.Focus();
        }

        protected void txtCopyZinkCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtStereotypeCost.Focus();
        }

        protected void txtStereotypeCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtPrintingCost.Focus();
        }

        protected void txtPrintingCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtBuyPaperCost.Focus();
        }

        protected void txtBuyPaperCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtVeneerCost.Focus();
        }

        protected void txtVeneerCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtLetterPressCost.Focus();
        }

        protected void txtLetterPressCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtMakingTemplateCost.Focus();
        }

        protected void txtMakingTemplateCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtSahafiCost.Focus();
        }

        protected void txtSahafiCost_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
            txtSumOutputCosts.Focus();
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