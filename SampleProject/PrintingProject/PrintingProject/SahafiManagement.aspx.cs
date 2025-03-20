using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Management.Smo.Agent;
using Telerik.Web.UI;
using System.Web.Script.Serialization;
using PrintingProject.BusinessLayer;


namespace PrintingProject
{
    public partial class SahafiManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        Sahafies _sahafies = new Sahafies();
        SahafiesFactory _sahafiesFactory = new SahafiesFactory();

        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        SahafiTypesFactory _sahafiTypesFactory = new SahafiTypesFactory();
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
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "SahafiManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
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
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(7);
            cmbOrderReceiver.DataSource = lstOrderReceiver;
            cmbOrderReceiver.DataBind();

            var lstSahafiType = _sahafiTypesFactory.GetAll();
            cmbSahafiType.DataSource = lstSahafiType;
            cmbSahafiType.DataBind();
        }
        private void BindGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstSahafies = _sahafiesFactory.GetAllForGrid(jobId);
            grdviewSahafi.DataSource = lstSahafies;
            grdviewSahafi.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _sahafies.OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
            _sahafies.JobId = int.Parse(Request.QueryString["JId"]);
            _sahafies.SahafiTypeId = int.Parse(cmbSahafiType.SelectedValue);
            if (!string.IsNullOrEmpty(txtTirazh.Text))
                _sahafies.Tirazh = int.Parse(txtTirazh.Text);
            _sahafies.Dimension = txtDimension.Text;
            _sahafies.PocketGlue = cmbPocketGlue.SelectedValue != "0" ? bool.Parse(cmbPocketGlue.SelectedValue) : (bool?)null;
            _sahafies.PaperGramazh = txtPaperGramazh.Text;
            if (!string.IsNullOrEmpty(txtTextFormCount.Text))
                _sahafies.TextFormCount = int.Parse(txtTextFormCount.Text);
            if (!string.IsNullOrEmpty(txtFormSum.Text))
                _sahafies.FormSum = int.Parse(txtFormSum.Text);
            _sahafies.Description = txtDescription.Text;
            _sahafies.InvoiceRow = txtInvoiceRow.Text;
            _sahafies.InvoiceNum = txtInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                _sahafies.InvoiceCost = decimal.Parse(txtInvoiceCost.Text);
            _sahafiesFactory.Insert(_sahafies);

            var message = "صحافی با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                      _sahafies.JobId + " ایجاد گردید";
            WriteOperation(message);

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
                var sahafi = _sahafiesFactory.GetAllBy(Sahafies.SahafiesFields.Id, id)[0];
                cmbOrderReceiver.SelectedValue = sahafi.OrderReceiverId.ToString();
                cmbSahafiType.SelectedValue = sahafi.SahafiTypeId.ToString();
                txtTirazh.Text = sahafi.Tirazh.ToString();
                txtDimension.Text = sahafi.Dimension;
                switch (sahafi.PocketGlue)
                {
                    case null:
                        cmbPocketGlue.SelectedValue = "0";
                        break;
                    case true:
                        cmbPocketGlue.SelectedValue = "true";
                        break;
                    case false:
                        cmbPocketGlue.SelectedValue = "false";
                        break;
                }
                txtPaperGramazh.Text = sahafi.PaperGramazh;
                txtTextFormCount.Text = sahafi.TextFormCount.ToString();
                txtFormSum.Text = sahafi.FormSum.ToString();
                txtDescription.Text = sahafi.Description;
                txtInvoiceRow.Text = sahafi.InvoiceRow;
                txtInvoiceNum.Text = sahafi.InvoiceNum;
                txtInvoiceCost.Text = sahafi.InvoiceCost.ToString();

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
                    var lstSahafi = _sahafiesFactory.GetAllBy(Sahafies.SahafiesFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                          lstSahafi[0].OrderReceiverId);
                    _sahafiesFactory.Delete(Sahafies.SahafiesFields.Id, id);

                    var message = "صحافی با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                    lstSahafi[0].JobId + " حذف گردید";
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
            cmbOrderReceiver.SelectedIndex = 0;
            cmbSahafiType.SelectedIndex = 0;
            cmbPocketGlue.SelectedIndex = 0;
            txtTirazh.Text = "";
            txtDimension.Text = "";
            txtPaperGramazh.Text = "";
            txtFormSum.Text = "";
            txtTextFormCount.Text = "";
            txtDescription.Text = "";
            txtInvoiceRow.Text = "";
            txtInvoiceNum.Text = "";
            txtInvoiceCost.Text = "";
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
            var lstSahafi = _sahafiesFactory.GetAllBy(Sahafies.SahafiesFields.Id, ItemId);
            if (lstSahafi.Count > 0)
            {
                lstSahafi[0].OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
                lstSahafi[0].SahafiTypeId = int.Parse(cmbSahafiType.SelectedValue);
                if (!string.IsNullOrEmpty(txtTirazh.Text))
                {
                    lstSahafi[0].Tirazh = int.Parse(txtTirazh.Text);
                }
                else
                {
                    lstSahafi[0].Tirazh = null;

                }
                lstSahafi[0].Dimension = txtDimension.Text;
                lstSahafi[0].PocketGlue = cmbPocketGlue.SelectedValue != "0" ? bool.Parse(cmbPocketGlue.SelectedValue) : (bool?)null;
                lstSahafi[0].PaperGramazh = txtPaperGramazh.Text;
                if (!string.IsNullOrEmpty(txtTextFormCount.Text))
                {
                    lstSahafi[0].TextFormCount = int.Parse(txtTextFormCount.Text);
                }
                else
                {
                    lstSahafi[0].TextFormCount = null;

                }
                if (!string.IsNullOrEmpty(txtFormSum.Text))
                {
                    lstSahafi[0].FormSum = int.Parse(txtFormSum.Text);

                }
                else
                {
                    lstSahafi[0].FormSum = null;

                }
                lstSahafi[0].Description = txtDescription.Text;
                lstSahafi[0].InvoiceRow = txtInvoiceRow.Text;
                lstSahafi[0].InvoiceNum = txtInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                {
                    lstSahafi[0].InvoiceCost = decimal.Parse(txtInvoiceCost.Text);
                }
                else
                {
                    lstSahafi[0].InvoiceCost = null;
                }
                _sahafiesFactory.Update(lstSahafi[0]);


                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewSahafi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewSahafi.PageIndex = e.NewPageIndex;
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
    }
}