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
using System.Data;


namespace PrintingProject
{
    public partial class JobManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        Jobs _jobs = new Jobs();
        JobsFactory _jobsFactory = new JobsFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        CustomersFactory _customersFactory = new CustomersFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "JobManagement.aspx"))
                {
                    PrintingProject.Session.IsLogin = false; Response.Redirect("Login.aspx");
                }
                BindCmb();
                ClearFrom();
                ChangeButtonsEnable("Normal");

                if (Request.QueryString["Index"] != null)
                {
                    grdviewJobs.PageIndex = int.Parse(Request.QueryString["Index"]);
                }

              
            }
        }
        public DataTable GetDataList(int? searchId, string searchName, string searchCode, int startIndex, int pageSize)
        {

            startIndex++;
            var lstJob = _jobsFactory.GetAllForGrid(searchId, searchName, searchCode, startIndex, pageSize);

            return lstJob;
        }
        public int GetTotalCount(int? searchId, string searchName, string searchCode)
        {
            return _jobsFactory.GetTotalCount(searchId, searchName, searchCode);
        }
        private void BindCmb()
        {
            var lstCustomers = _customersFactory.GetAll();
            cmbCustomers.DataSource = lstCustomers;
            cmbCustomers.DataBind();

            var lstJobNames = _jobsFactory.GetAll(lstCustomers[0].Id);
            cmbJobName.DataSource = lstJobNames;
            cmbJobName.DataBind();

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _jobs.Name = cmbJobName.Text;
            _jobs.CustomerId = int.Parse(cmbCustomers.SelectedValue);
            _jobs.CreateDate = DateTime.Now;
            _jobs.Description = txtDescription.Text;
            _jobs.Code = txtCode.Text;
            _jobs.StoreCode = lblStoreCode.Text != "" ? int.Parse(lblStoreCode.Text) : (int?)null;
            _jobsFactory.Insert(_jobs);

            var message = "دستور کار با شماره " + _jobs.Id + " ایجاد شد.";
            WriteOperation(message);

            ClearFrom();
            BindCmb();
            grdviewJobs.DataBind();

            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeButtonsEnable("Normal");
            ClearFrom();
            BindCmb();
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
                var job = _jobsFactory.GetAllBy(Jobs.JobsFields.Id, id);

                cmbCustomers.SelectedValue = job[0].CustomerId.ToString();

                var lstJobNames = _jobsFactory.GetAll(job[0].CustomerId);
                cmbJobName.DataSource = lstJobNames;
                cmbJobName.DataBind();

                cmbJobName.Text = job[0].Name;
                if (job[0].StoreCode != null)
                    cmbJobName.SelectedValue = job[0].StoreCode.ToString();
                txtCode.Text = job[0].Code;
                lblStoreCode.Text = job[0].StoreCode.ToString();
                txtDescription.Text = job[0].Description;
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
                    _jobsFactory.Delete(Jobs.JobsFields.Id, id);

                    var message = "دستور کار با شماره " + id + " حذف شد.";
                    WriteOperation(message);
                    BindCmb();
                    grdviewJobs.DataBind();

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
            cmbCustomers.SelectedIndex = 0;
            txtDescription.Text = "";
            txtCode.Text = "";
            cmbJobName.Text = "";

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
            var lstJob = _jobsFactory.GetAllBy(Jobs.JobsFields.Id, ItemId);
            if (lstJob.Count > 0)
            {
                lstJob[0].Name = cmbJobName.Text;
                lstJob[0].CustomerId = int.Parse(cmbCustomers.SelectedValue);
                lstJob[0].Description = txtDescription.Text;
                lstJob[0].Code = txtCode.Text;
                lstJob[0].StoreCode = lblStoreCode.Text != "" ? int.Parse(lblStoreCode.Text) : (int?)null;
                _jobsFactory.Update(lstJob[0]);

                var message = "دستور کار با شماره " + lstJob[0].Id + " ویرایش شد.";
                WriteOperation(message);


                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindCmb();
                grdviewJobs.DataBind();

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void Litography_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewJobs.PageIndex;
                Response.Redirect("LitographyManagement.aspx?JId=" + btn.CssClass + "&Index=" + pageindex, false);
                
               
            }
        }
        protected void Printing_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewJobs.PageIndex;
                Response.Redirect("PrintingManagement.aspx?JId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void Paper_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewJobs.PageIndex;
                Response.Redirect("PaperManagement.aspx?JId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void Veneer_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewJobs.PageIndex;
                Response.Redirect("VeneerManagement.aspx?JId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void LetterPress_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewJobs.PageIndex;
                Response.Redirect("LetterPressManagement.aspx?JId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void MakingTemplate_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewJobs.PageIndex;
                Response.Redirect("MakingTemplateManagement.aspx?JId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void Sahafi_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewJobs.PageIndex;
                Response.Redirect("SahafiManagement.aspx?JId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void FinalInvoice_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewJobs.PageIndex;
                Response.Redirect("FinalInvoiceManagement.aspx?JId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void JobCopy_Click(object sender, ImageClickEventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int jobId = int.Parse(btn.CssClass);
                _jobsFactory.Copy(jobId);
                grdviewJobs.DataBind();
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {

            grdviewJobs.DataBind();
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

        protected void cmbJobName_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            int customerId = int.Parse(cmbCustomers.SelectedValue);
            var lstJobNames = _jobsFactory.GetAll(customerId);
            if (cmbJobName.SelectedValue != "")
            {
                int storeCode = int.Parse(cmbJobName.SelectedValue);
                var job = lstJobNames.Where(x => x.StoreCode == storeCode).Select(p => p.Code).ToList();
                txtCode.Text = job[0];
                lblStoreCode.Text = cmbJobName.SelectedValue;
            }
            else
            {
                txtCode.Text = "";
                lblStoreCode.Text = "";

            }

        }

        protected void cmbCustomers_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            int customerId = int.Parse(cmbCustomers.SelectedValue);

            var lstJobNames = _jobsFactory.GetAll(customerId);
            cmbJobName.DataSource = lstJobNames;
            cmbJobName.DataBind();
        }


    }
}