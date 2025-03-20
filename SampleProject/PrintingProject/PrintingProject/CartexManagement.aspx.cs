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
    public partial class CartexManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        Cartexes _cartexes = new Cartexes();
        CartexesFactory _cartexesFactory = new CartexesFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        CustomersFactory _customersFactory = new CustomersFactory();
        JobsFactory _jobsFactory = new JobsFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "CartexManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }
                BindCmb();
                ClearFrom();
                ChangeButtonsEnable("Normal");

                if (Request.QueryString["Index"] != null)
                {
                    grdviewCartex.PageIndex = int.Parse(Request.QueryString["Index"]);
                }
            }
        }
        public DataTable GetDataList(string searchJobName, string searchJobCode, int startIndex, int pageSize)
        {

            startIndex++;
            var lstJob = _cartexesFactory.GetAllForGrid(searchJobName, searchJobCode, startIndex, pageSize);

            return lstJob;
        }
        public int GetTotalCount(string searchJobName, string searchJobCode)
        {
            return _cartexesFactory.GetTotalCount(searchJobName, searchJobCode);
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

            var lstCartex = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.JobCode, txtCode.Text);
            if (lstCartex.Count > 0)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "کارتکس با این کد کار موجود است.";
            }
            else
            {
                _cartexes.JobName = cmbJobName.Text;
                _cartexes.CustomerId = int.Parse(cmbCustomers.SelectedValue);
                _cartexes.Description = txtDescription.Text;
                _cartexes.JobCode = txtCode.Text;
                _cartexes.Stock = 0;
                _cartexesFactory.Insert(_cartexes);

                var message = "کارتکس با کد کار " + _cartexes.JobCode + " ایجاد شد.";
                WriteOperation(message);

                ClearFrom();
                BindCmb();
                grdviewCartex.DataBind();

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
            }

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
                var cartex = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, id);

                cmbCustomers.SelectedValue = cartex[0].CustomerId.ToString();

                var lstJobNames = _jobsFactory.GetAll(cartex[0].CustomerId);
                cmbJobName.DataSource = lstJobNames;
                cmbJobName.DataBind();

                cmbJobName.Text = cartex[0].JobName;
                cmbJobName.SelectedValue = cartex[0].JobCode;
                txtCode.Text = cartex[0].JobCode;
                lblStoreCode.Text = cartex[0].StoreCode.ToString();
                txtDescription.Text = cartex[0].Description;
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
                    var cartex = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, id);

                    var message = "کارتکس با کد کار " + cartex[0].JobCode + " حذف شد.";
                    WriteOperation(message);

                    _cartexesFactory.OperationBeforeDelete(id);
                    _cartexesFactory.Delete(Cartexes.CartexesFields.Id, id);
                    
                    BindCmb();
                    grdviewCartex.DataBind();

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
            var lstCartex = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, ItemId);
            if (lstCartex.Count > 0)
            {
                lstCartex[0].JobName = cmbJobName.Text;
                lstCartex[0].CustomerId = int.Parse(cmbCustomers.SelectedValue);
                lstCartex[0].Description = txtDescription.Text;
                lstCartex[0].JobCode = txtCode.Text;
                lstCartex[0].StoreCode = lblStoreCode.Text != "" ? int.Parse(lblStoreCode.Text) : (int?)null;
                _cartexesFactory.Update(lstCartex[0]);

                var message = "کارتکس با کد کار " + lstCartex[0].JobCode + " ویرایش شد.";
                WriteOperation(message);


                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindCmb();
                grdviewCartex.DataBind();

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void PrimaryStock_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewCartex.PageIndex;
                Response.Redirect("PrimaryStockManagement.aspx?CId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void ProductionOrder_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewCartex.PageIndex;
                Response.Redirect("ProductionOrderManagement.aspx?CId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }
        protected void ProductDelivery_Click(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;
            if (btn != null)
            {
                var pageindex = grdviewCartex.PageIndex;
                Response.Redirect("ProductDeliveryManagement.aspx?CId=" + btn.CssClass + "&Index=" + pageindex, false);
            }
        }



        protected void btnSearch_Click(object sender, EventArgs e)
        {

            grdviewCartex.DataBind();
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
            cmbJobName.Text = "";
            var lstJobNames = _jobsFactory.GetAll(customerId);
            cmbJobName.DataSource = lstJobNames;
            cmbJobName.DataBind();
        }


    }
}