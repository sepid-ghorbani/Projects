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
    public partial class MakingTemplateManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        MakingTemplates _makingTemplates = new MakingTemplates();
        MakingTemplatesFactory _makingTemplatesFactory = new MakingTemplatesFactory();

        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        LetterPressDevicesFactory _letterPressDevicesFactory = new LetterPressDevicesFactory();
        TemplateMaterialTypesFactory _templateMaterialTypesFactory = new TemplateMaterialTypesFactory();
        BladeTypesFactory _bladeTypesFactory = new BladeTypesFactory();
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
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "MakingTemplateManagement.aspx"))
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
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(6);
            cmbOrderReceiver.DataSource = lstOrderReceiver;
            cmbOrderReceiver.DataBind();

            var lstLetterPressDevices = _letterPressDevicesFactory.GetAll();
            cmbLetterPressDevice.DataSource = lstLetterPressDevices;
            cmbLetterPressDevice.DataBind();

            var lstTemplateMaterialType = _templateMaterialTypesFactory.GetAll();
            cmbTemplateMaterialType.DataSource = lstTemplateMaterialType;
            cmbTemplateMaterialType.DataBind();

            var lstBladeType = _bladeTypesFactory.GetAll();
            cmbBladeType.DataSource = lstBladeType;
            cmbBladeType.DataBind();

        }
        private void BindGrid()
        {
            int jobId = int.Parse(Request.QueryString["JId"]);
            var lstMakingTemplate = _makingTemplatesFactory.GetAllForGrid(jobId);
            grdviewMakingTemplate.DataSource = lstMakingTemplate;
            grdviewMakingTemplate.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _makingTemplates.OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
            _makingTemplates.JobId = int.Parse(Request.QueryString["JId"]);
            _makingTemplates.LetterPressDeviceId = int.Parse(cmbLetterPressDevice.SelectedValue);
            _makingTemplates.TemplateMaterialTypeId = int.Parse(cmbTemplateMaterialType.SelectedValue);
            _makingTemplates.Dimension = txtDimension.Text;
            if (!string.IsNullOrEmpty(txtCount.Text))
                _makingTemplates.Count = int.Parse(txtCount.Text);
            _makingTemplates.BladeTypeId = int.Parse(cmbBladeType.SelectedValue);
            _makingTemplates.PorferazhModel = txtPorferazhModel.Text;
            _makingTemplates.Description = txtDescription.Text;
            _makingTemplates.InvoiceRow = txtInvoiceRow.Text;
            _makingTemplates.InvoiceNum = txtInvoiceNum.Text;
            if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                _makingTemplates.InvoiceCost = decimal.Parse(txtInvoiceCost.Text);

            _makingTemplatesFactory.Insert(_makingTemplates);

            var message = "ساخت قالب با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                        _makingTemplates.JobId + " ایجاد گردید";
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
                var makingTemplate = _makingTemplatesFactory.GetAllBy(MakingTemplates.MakingTemplatesFields.Id, id)[0];
                cmbOrderReceiver.SelectedValue = makingTemplate.OrderReceiverId.ToString();
                cmbLetterPressDevice.SelectedValue = makingTemplate.LetterPressDeviceId.ToString();
                cmbTemplateMaterialType.SelectedValue = makingTemplate.TemplateMaterialTypeId.ToString();
                txtDimension.Text = makingTemplate.Dimension;
                txtCount.Text = makingTemplate.Count.ToString();
                cmbBladeType.SelectedValue = makingTemplate.BladeTypeId.ToString();
                txtPorferazhModel.Text = makingTemplate.PorferazhModel;
                txtDescription.Text = makingTemplate.Description;
                txtInvoiceRow.Text = makingTemplate.InvoiceRow;
                txtInvoiceNum.Text = makingTemplate.InvoiceNum;
                txtInvoiceCost.Text = makingTemplate.InvoiceCost.ToString();

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
                    var lstMakingTemplate = _makingTemplatesFactory.GetAllBy(MakingTemplates.MakingTemplatesFields.Id, id);
                    var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                                                                        lstMakingTemplate[0].OrderReceiverId);
                    _makingTemplatesFactory.Delete(MakingTemplates.MakingTemplatesFields.Id, id);

                    var message = "دایکات با سفارش گیرنده " + lstOrderReceiver[0].Name + " برای دستور کار با شماره " +
                     lstMakingTemplate[0].JobId + " حذف گردید";
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
            cmbLetterPressDevice.SelectedIndex = 0;
            cmbTemplateMaterialType.SelectedIndex = 0;
            txtDimension.Text = "";
            txtCount.Text = "";
            cmbBladeType.SelectedIndex = 0;
            txtPorferazhModel.Text = "";
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
            var lstMakingTemplate = _makingTemplatesFactory.GetAllBy(MakingTemplates.MakingTemplatesFields.Id, ItemId);
            if (lstMakingTemplate.Count > 0)
            {
                lstMakingTemplate[0].OrderReceiverId = int.Parse(cmbOrderReceiver.SelectedValue);
                lstMakingTemplate[0].LetterPressDeviceId = int.Parse(cmbLetterPressDevice.SelectedValue);
                lstMakingTemplate[0].TemplateMaterialTypeId = int.Parse(cmbTemplateMaterialType.SelectedValue);
                lstMakingTemplate[0].Dimension = txtDimension.Text;
                if (!string.IsNullOrEmpty(txtCount.Text))
                {
                    lstMakingTemplate[0].Count = int.Parse(txtCount.Text);

                }
                else
                {
                    lstMakingTemplate[0].Count = null;

                }
                lstMakingTemplate[0].BladeTypeId = int.Parse(cmbBladeType.SelectedValue);
                lstMakingTemplate[0].PorferazhModel = txtPorferazhModel.Text;
                lstMakingTemplate[0].Description = txtDescription.Text;
                lstMakingTemplate[0].InvoiceRow = txtInvoiceRow.Text;
                lstMakingTemplate[0].InvoiceNum = txtInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtInvoiceCost.Text))
                {
                    lstMakingTemplate[0].InvoiceCost = decimal.Parse(txtInvoiceCost.Text);
                }
                else
                {
                    lstMakingTemplate[0].InvoiceCost = null;
                }
                _makingTemplatesFactory.Update(lstMakingTemplate[0]);

                var message = "دایکات با سفارش گیرنده " + cmbOrderReceiver.Text + " برای دستور کار با شماره " +
                      lstMakingTemplate[0].JobId + " ویرایش گردید";
                WriteOperation(message);

                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewMakingTemplate_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewMakingTemplate.PageIndex = e.NewPageIndex;
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