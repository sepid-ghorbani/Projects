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
    public partial class PrimaryStockManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        PrimaryStock _primaryStock = new PrimaryStock();
        PrimaryStockFactory _primaryStockFactory = new PrimaryStockFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        JobTypesFactory _jobTypesFactory = new JobTypesFactory();
        CartexesFactory _cartexesFactory = new CartexesFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "PrimaryStockManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }
                BindCmb();
                BindGrid();
                ClearFrom();
                ChangeButtonsEnable("Normal");

                int cartexId = int.Parse(Request.QueryString["CId"]);
                var cartext = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, cartexId)[0];
                lblJobName.Text = cartext.JobCode + " - " + cartext.JobName;
                lblRemain.Text = cartext.Stock.ToString();

                HyperLinkPrimaryStock.NavigateUrl = "~/PrimaryStockManagement.aspx?CId=" + Request.QueryString["CId"] + "&Index=" + Request.QueryString["Index"];
                HyperProductionOrder.NavigateUrl = "~/ProductionOrderManagement.aspx?CId=" + Request.QueryString["CId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkProductDelivery.NavigateUrl = "~/ProductDeliveryManagement.aspx?CId=" + Request.QueryString["CId"] + "&Index=" + Request.QueryString["Index"];

            }
        }
        private void BindCmb()
        {
            var lstOrderReceiver = _orderReceiversFactory.GetAllByLevel(8);
            cmbFromOrderReceivers.DataSource = lstOrderReceiver;
            cmbFromOrderReceivers.DataBind();

            cmbToOrderReceivers.DataSource = lstOrderReceiver;
            cmbToOrderReceivers.DataBind();

            var lstJobTypes = _jobTypesFactory.GetAll();
            cmbJobTypes.DataSource = lstJobTypes;
            cmbJobTypes.DataBind();
        }
        private void BindGrid()
        {
            int cartexId = int.Parse(Request.QueryString["CId"]);
            var lstPrimaryStock = _primaryStockFactory.GetAllForGrid(cartexId);
            grdviewPrimaryStock.DataSource = lstPrimaryStock;
            grdviewPrimaryStock.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            _primaryStock.CartexId = int.Parse(Request.QueryString["CId"]);
            _primaryStock.FromOrderReceiversId = int.Parse(cmbFromOrderReceivers.SelectedValue);
            _primaryStock.ToOrderReceiversId = int.Parse(cmbToOrderReceivers.SelectedValue);
            _primaryStock.JobTypesId = int.Parse(cmbJobTypes.SelectedValue);
            if (!string.IsNullOrEmpty(txtJobCount.Text))
                _primaryStock.JobCount = int.Parse(txtJobCount.Text);
            _primaryStock.Description = txtDescription.Text;
            _primaryStock.CreateDate = DateTime.Now;
            _primaryStockFactory.Insert(_primaryStock);


            var message = "موجودی اولیه برای کارتکس با نام کار  " + lblJobName.Text + " ایجاد گردید";
            WriteOperation(message);


            var lstCartext = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, _primaryStock.CartexId);
            lstCartext[0].Stock += _primaryStock.JobCount??0;
            _cartexesFactory.Update(lstCartext[0]);

            var lstPrimaryStock = _primaryStockFactory.GetAllBy(PrimaryStock.PrimaryStockFields.Id, _primaryStock.Id);
            _primaryStockFactory.Update(lstPrimaryStock[0]);
            

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
                var primaryStock = _primaryStockFactory.GetAllBy(PrimaryStock.PrimaryStockFields.Id, id)[0];
                cmbFromOrderReceivers.SelectedValue = primaryStock.FromOrderReceiversId.ToString();
                cmbToOrderReceivers.SelectedValue = primaryStock.ToOrderReceiversId.ToString();
                cmbJobTypes.SelectedValue = primaryStock.JobTypesId.ToString();
                txtJobCount.Text = primaryStock.JobCount.ToString();
                txtJobCount.Enabled = false;
                txtDescription.Text = primaryStock.Description;

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
                    var lstPrimaryStock = _primaryStockFactory.GetAllBy(PrimaryStock.PrimaryStockFields.Id, id);

                    var lstCartext = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, lstPrimaryStock[0].CartexId);
                    lstCartext[0].Stock -= lstPrimaryStock[0].JobCount ?? 0;
                    _cartexesFactory.Update(lstCartext[0]);

                    _primaryStockFactory.Delete(PrimaryStock.PrimaryStockFields.Id, id);

                    var message = "موجودی اولیه برای کارتکس با نام کار  " + lblJobName.Text + " حذف گردید";
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
            cmbFromOrderReceivers.SelectedIndex = 0;
            cmbToOrderReceivers.SelectedIndex = 0;
            cmbJobTypes.SelectedIndex = 0;
            txtJobCount.Text = "";
            txtDescription.Text = "";
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
            var lstPrimaryStock = _primaryStockFactory.GetAllBy(PrimaryStock.PrimaryStockFields.Id, ItemId);
            if (lstPrimaryStock.Count > 0)
            {
                lstPrimaryStock[0].CartexId = int.Parse(Request.QueryString["CId"]);
                lstPrimaryStock[0].FromOrderReceiversId = int.Parse(cmbFromOrderReceivers.SelectedValue);
                lstPrimaryStock[0].ToOrderReceiversId = int.Parse(cmbToOrderReceivers.SelectedValue);
                lstPrimaryStock[0].JobTypesId = int.Parse(cmbJobTypes.SelectedValue);
                if (!string.IsNullOrEmpty(txtJobCount.Text))
                {
                    lstPrimaryStock[0].JobCount = int.Parse(txtJobCount.Text);

                }
                else
                {
                    lstPrimaryStock[0].JobCount = null;

                }
                lstPrimaryStock[0].Description = txtDescription.Text;


                _primaryStockFactory.Update(lstPrimaryStock[0]);

                var message = "موجودی اولیه برای کارتکس با نام کار  " + lblJobName.Text + " ویرایش گردید";
                WriteOperation(message);

                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewPrimaryStock_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewPrimaryStock.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CartexManagement.aspx?Index=" + Request.QueryString["Index"]);
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