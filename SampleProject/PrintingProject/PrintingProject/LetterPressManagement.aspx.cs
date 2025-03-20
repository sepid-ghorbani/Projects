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
    public partial class LetterPressManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        LetterPresses _letterPresses = new LetterPresses();
        LetterPressesFactory _letterPressesFactory = new LetterPressesFactory();

        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        LetterPressTypesFactory _letterPressTypesFactory = new LetterPressTypesFactory();
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
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "LetterPressManagement.aspx"))
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
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(5);
            cmbOrderReceiver.DataSource = lstOrderReceiver;
            cmbOrderReceiver.DataBind();

            var lstLetterPressType = _letterPressTypesFactory.GetAll();
            cmbLetterPressType.DataSource = lstLetterPressType;
            cmbLetterPressType.DataBind();
        }
        private void BindGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstLetterPresses = _letterPressesFactory.GetAllForGrid(jobId);
            grdviewLetterPress.DataSource = lstLetterPresses;
            grdviewLetterPress.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _letterPresses.OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
            _letterPresses.JobId = int.Parse(Request.QueryString["JId"]);
            _letterPresses.OrderLetterPress = 0;
            _letterPresses.LetterPressTypeId = int.Parse(cmbLetterPressType.SelectedValue);
            if (!string.IsNullOrEmpty(txtTirazh.Text))
                _letterPresses.Tirazh = int.Parse(txtTirazh.Text);
            _letterPresses.Dimension = txtDimension.Text;
            _letterPresses.PaperGramazh = txtPaperGramazh.Text;
            _letterPresses.Description = txtDescription.Text;

            _letterPresses.InvoiceRow = txtInvoiceRow.Text;
            _letterPresses.InvoiceNum = txtInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                _letterPresses.InvoiceCost = decimal.Parse(txtInvoiceCost.Text);

            _letterPressesFactory.Insert(_letterPresses);

            var message = "دایکات با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                       _letterPresses.JobId + " ایجاد گردید";
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
                var letterPress = _letterPressesFactory.GetAllBy(LetterPresses.LetterPressesFields.Id, id)[0];
                cmbOrderReceiver.SelectedValue = letterPress.OrderReceiverId.ToString();
                cmbLetterPressType.SelectedValue = letterPress.LetterPressTypeId.ToString();
                txtTirazh.Text = letterPress.Tirazh.ToString();
                txtDimension.Text = letterPress.Dimension;
                txtPaperGramazh.Text = letterPress.PaperGramazh;
                txtDescription.Text = letterPress.Description;
                txtInvoiceRow.Text = letterPress.InvoiceRow;
                txtInvoiceNum.Text = letterPress.InvoiceNum;
                txtInvoiceCost.Text = letterPress.InvoiceCost.ToString();


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
                    var lstLetterPress = _letterPressesFactory.GetAllBy(LetterPresses.LetterPressesFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                          lstLetterPress[0].OrderReceiverId);
                    _letterPressesFactory.Delete(LetterPresses.LetterPressesFields.Id, id);

                    var message = "دایکات با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                     lstLetterPress[0].JobId + " حذف گردید";
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
            cmbLetterPressType.SelectedIndex = 0;
            txtTirazh.Text = "";
            txtDimension.Text = "";
            txtPaperGramazh.Text = "";
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
            var lstLetterPress = _letterPressesFactory.GetAllBy(LetterPresses.LetterPressesFields.Id, ItemId);
            if (lstLetterPress.Count > 0)
            {
                lstLetterPress[0].OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
                lstLetterPress[0].LetterPressTypeId = int.Parse(cmbLetterPressType.SelectedValue);
                if (!string.IsNullOrEmpty(txtTirazh.Text))
                {
                    lstLetterPress[0].Tirazh = int.Parse(txtTirazh.Text);
                }
                else
                {
                    lstLetterPress[0].Tirazh = null;
                }
                lstLetterPress[0].Dimension = txtDimension.Text;
                lstLetterPress[0].PaperGramazh = txtPaperGramazh.Text;
                lstLetterPress[0].Description = txtDescription.Text;

                lstLetterPress[0].InvoiceRow = txtInvoiceRow.Text;
                lstLetterPress[0].InvoiceNum = txtInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                {
                    lstLetterPress[0].InvoiceCost = decimal.Parse(txtInvoiceCost.Text);
                }
                else
                {
                    lstLetterPress[0].InvoiceCost = null;
                }
                _letterPressesFactory.Update(lstLetterPress[0]);

                var message = "دایکات با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                     lstLetterPress[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewLetterPress_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewLetterPress.PageIndex = e.NewPageIndex;
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