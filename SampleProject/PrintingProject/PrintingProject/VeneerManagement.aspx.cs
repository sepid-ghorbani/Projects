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
    public partial class VeneerManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        Veneers _veneers = new Veneers();
        VeneersFactory _veneersFactory = new VeneersFactory();

        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        VeneerTypesFactory _veneerTypesFactory = new VeneerTypesFactory();
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
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "VeneerManagement.aspx"))
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
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(4);
            cmbOrderReceiver.DataSource = lstOrderReceiver;
            cmbOrderReceiver.DataBind();

            var lstVennerType = _veneerTypesFactory.GetAll();
            cmbVeneerType.DataSource = lstVennerType;
            cmbVeneerType.DataBind();
        }
        private void BindGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstVeneer = _veneersFactory.GetAllForGrid(jobId);
            grdviewVeneer.DataSource = lstVeneer;
            grdviewVeneer.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _veneers.OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
            _veneers.JobId = int.Parse(Request.QueryString["JId"]);
            _veneers.OrderVeneer = 0;
            _veneers.VeneerTypeId = int.Parse(cmbVeneerType.SelectedValue);
            _veneers.Model = int.Parse(cmbModel.SelectedValue);
            if (!string.IsNullOrEmpty(txtTirazh.Text))
                _veneers.Tirazh = int.Parse(txtTirazh.Text);
            _veneers.Dimension = txtDimension.Text;
            _veneers.PaperGramazh = txtPaperGramazh.Text;
            _veneers.Description = txtDescription.Text;

            _veneers.InvoiceRow = txtInvoiceRow.Text;
            _veneers.InvoiceNum = txtInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                _veneers.InvoiceCost = decimal.Parse(txtInvoiceCost.Text);

            _veneersFactory.Insert(_veneers);

            var message = "روکش با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                     _veneers.JobId + " ایجاد گردید";
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
                var veneer = _veneersFactory.GetAllBy(Veneers.VeneersFields.Id, id)[0];
                cmbOrderReceiver.SelectedValue = veneer.OrderReceiverId.ToString();
                cmbVeneerType.SelectedValue = veneer.VeneerTypeId.ToString();
                cmbModel.SelectedValue = veneer.Model.ToString();
                txtTirazh.Text = veneer.Tirazh.ToString();
                txtDimension.Text = veneer.Dimension;
                txtPaperGramazh.Text = veneer.PaperGramazh;
                txtDescription.Text = veneer.Description;
                txtInvoiceRow.Text = veneer.InvoiceRow;
                txtInvoiceNum.Text = veneer.InvoiceNum;
                txtInvoiceCost.Text = veneer.InvoiceCost.ToString();


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
                    var lstVeneer = _veneersFactory.GetAllBy(Veneers.VeneersFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                          lstVeneer[0].OrderReceiverId);
                    _veneersFactory.Delete(Veneers.VeneersFields.Id, id);

                    var message = "روکش با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                    lstVeneer[0].JobId + " حذف گردید";
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
            cmbVeneerType.SelectedIndex = 0;
            cmbModel.SelectedIndex = 0;
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
            var lstVeneer = _veneersFactory.GetAllBy(Veneers.VeneersFields.Id, ItemId);
            if (lstVeneer.Count > 0)
            {
                lstVeneer[0].OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
                lstVeneer[0].VeneerTypeId = int.Parse(cmbVeneerType.SelectedValue);
                lstVeneer[0].Model = int.Parse(cmbModel.SelectedValue);
                if (!string.IsNullOrEmpty(txtTirazh.Text))
                {
                    lstVeneer[0].Tirazh = int.Parse(txtTirazh.Text);
                }
                else
                {
                    lstVeneer[0].Tirazh = null;
                }
                lstVeneer[0].Dimension = txtDimension.Text;
                lstVeneer[0].PaperGramazh = txtPaperGramazh.Text;
                lstVeneer[0].Description = txtDescription.Text;
                lstVeneer[0].InvoiceRow = txtInvoiceRow.Text;
                lstVeneer[0].InvoiceNum = txtInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                {
                    lstVeneer[0].InvoiceCost = decimal.Parse(txtInvoiceCost.Text);
                }
                else
                {
                    lstVeneer[0].InvoiceCost = null;
                }
                _veneersFactory.Update(lstVeneer[0]);

                var message = "روکش با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                    lstVeneer[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewVeneer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewVeneer.PageIndex = e.NewPageIndex;
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