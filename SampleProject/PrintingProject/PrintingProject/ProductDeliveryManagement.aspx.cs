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
    public partial class ProductDeliveryManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        public int OrderReceiverId { get { return (int)ViewState["OrderReceiverId"]; } set { ViewState["OrderReceiverId"] = value; } }
        public int JobTypesId { get { return (int)ViewState["JobTypesId"]; } set { ViewState["JobTypesId"] = value; } }


        ProductDelivery _productDelivery = new ProductDelivery();
        ProductDeliveryFactory _productDeliveryFactory = new ProductDeliveryFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();
        JobTypesFactory _jobTypesFactory = new JobTypesFactory();
        CartexesFactory _cartexesFactory = new CartexesFactory();
        DeliveryReceiversFactory _deliveryReceiversFactory = new DeliveryReceiversFactory();
        JobNamesFactory _jobNamesFactory = new JobNamesFactory();
        PrimaryStockFactory _primaryStockFactory = new PrimaryStockFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "ProductDeliveryManagement.aspx"))
                {
                    PrintingProject.Session.IsLogin = false; Response.Redirect("Login.aspx");
                }
                ClearFrom();

                BindCmb();
                BindLabels();
                BindGrid();
                ChangeButtonsEnable("Normal");

                HyperLinkPrimaryStock.NavigateUrl = "~/PrimaryStockManagement.aspx?CId=" + Request.QueryString["CId"] + "&Index=" + Request.QueryString["Index"];
                HyperProductionOrder.NavigateUrl = "~/ProductionOrderManagement.aspx?CId=" + Request.QueryString["CId"] + "&Index=" + Request.QueryString["Index"];
                HyperLinkProductDelivery.NavigateUrl = "~/ProductDeliveryManagement.aspx?CId=" + Request.QueryString["CId"] + "&Index=" + Request.QueryString["Index"];

            }
        }

        private void BindLabels()
        {
            int cartexId = int.Parse(Request.QueryString["CId"]);
            var cartext = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, cartexId)[0];
            lblJobName.Text = cartext.JobCode + " - " + cartext.JobName;
            lblRemain.Text = cartext.Stock.ToString();

            var job = _jobNamesFactory.GetAllBy(JobNames.JobNamesFields.Code, cartext.JobCode);
            if (job != null)
            {
                var fee1 = job[0].Fee1;
                var fee2 = job[0].Fee2;

                txtFee1.Text = fee1.ToString();
                if (!string.IsNullOrEmpty(txtDeliveryCount.Text))
                {
                    var deliveryCount = int.Parse(txtDeliveryCount.Text);

                    lblCostSum1.Text = string.Format("{0:#,###0}", (deliveryCount * fee1));
                    lblCostSum2.Text = string.Format("{0:#,###0}", (deliveryCount * fee2));
                }
                else
                {
                    lblCostSum1.Text = "";
                    lblCostSum2.Text = "";
                }
            }

        }
        private void BindCmb()
        {

            var lstDeliveryReceiver = _deliveryReceiversFactory.GetAll();
            var deliveryReceiver = new DeliveryReceivers()
            {
                Id = 0,
                Name = "ندارد"
            };
            lstDeliveryReceiver.Insert(0, deliveryReceiver);
            cmbDeliveryReceivers.DataSource = lstDeliveryReceiver;
            cmbDeliveryReceivers.DataBind();

            int cartexId = int.Parse(Request.QueryString["CId"]);
            var lstPrimaryStock = _primaryStockFactory.GetAllBy(PrimaryStock.PrimaryStockFields.CartexId, cartexId).OrderByDescending(x=>x.Id).ToList();
            if (lstPrimaryStock != null)
            {
                var lstJobType = _jobTypesFactory.GetAllBy(JobTypes.JobTypesFields.Id, lstPrimaryStock[0].JobTypesId);
                lblJobType.Text = lstJobType[0].Name;
                JobTypesId = lstPrimaryStock[0].JobTypesId;

                var lstOrderReceiver = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id,
                    lstPrimaryStock[0].ToOrderReceiversId);
                lblOrderReceiver.Text = lstOrderReceiver[0].Name;
                OrderReceiverId = lstPrimaryStock[0].ToOrderReceiversId;
            }

        }
        private void BindGrid()
        {
            int cartexId = int.Parse(Request.QueryString["CId"]);
            var lstProductDelivery = _productDeliveryFactory.GetAllForGrid(cartexId);
            grdviewProductDelivery.DataSource = lstProductDelivery;
            grdviewProductDelivery.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblJobType.Text))
            {
                _productDelivery.CartexId = int.Parse(Request.QueryString["CId"]);

                if (_productDeliveryFactory.HasPermissionToInsert(_productDelivery.CartexId))
                {
                    _productDelivery.OrderReceiverId = OrderReceiverId;
                    _productDelivery.JobTypesId = JobTypesId;

                    if (int.Parse(cmbDeliveryReceivers.SelectedValue) != 0)
                    {
                        _productDelivery.DeliveryReceiversId = int.Parse(cmbDeliveryReceivers.SelectedValue);
                    }
                    else
                    {
                        _productDelivery.DeliveryReceiversId = null;
                    }

                    _productDelivery.DeliveryCount = int.Parse(txtDeliveryCount.Text);
                    _productDelivery.Fee1 = decimal.Parse(txtFee1.Text);
                    _productDelivery.DeliveryDate = dtpDeliveryDate.Date.Value;
                    _productDelivery.ReceiptNum = txtReceiptNum.Text;
                    _productDelivery.Description = txtDescription.Text;

                    _productDelivery.InputInvoiceDate = dtpInputInvoiceDate.Date;
                    _productDelivery.InputInvoiceRow = txtInputInvoiceRow.Text;
                    _productDelivery.InputInvoiceNum = txtInputInvoiceNum.Text;
                    if (!string.IsNullOrEmpty(txtInputInvoiceCost.Text))
                        _productDelivery.InputInvoiceCost = decimal.Parse(txtInputInvoiceCost.Text);

                    _productDelivery.OutputInvoiceDate = dtpOutputInvoiceDate.Date;
                    _productDelivery.OutputInvoiceRow = txtOutputInvoiceRow.Text;
                    _productDelivery.OutputInvoiceNum = txtOutputInvoiceNum.Text;
                    if (!string.IsNullOrEmpty(txtOutputInvoiceCost.Text))
                        _productDelivery.OutputInvoiceCost = decimal.Parse(txtOutputInvoiceCost.Text);

                    _productDeliveryFactory.Insert(_productDelivery);


                    var message = "تحویل محصول برای کارتکس با نام کار  " + lblJobName.Text + " ایجاد گردید";
                    WriteOperation(message);

                    var lstCartext = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, _productDelivery.CartexId);
                    lstCartext[0].Stock -= _productDelivery.DeliveryCount;
                    _cartexesFactory.Update(lstCartext[0]);

                    var productDelivery =
                        _productDeliveryFactory.GetAllBy(ProductDelivery.ProductDeliveryFields.Id, _productDelivery.Id)[0];
                    _productDeliveryFactory.Update(productDelivery);

                    ClearFrom();
                    BindGrid();
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
                }
                else
                {
                     lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "سفارش تولید ثبت نشده است.";
                }

                
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "موجودی اولیه ثبت نشده است.";
            }

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
                var productDelivery = _productDeliveryFactory.GetAllBy(ProductDelivery.ProductDeliveryFields.Id, id)[0];

                if (productDelivery.DeliveryReceiversId != null)
                {
                    cmbDeliveryReceivers.SelectedValue = productDelivery.DeliveryReceiversId.ToString();
                }
                else
                {
                    cmbDeliveryReceivers.SelectedIndex = 0;
                }
                txtDeliveryCount.Text = productDelivery.DeliveryCount.ToString();
                txtDeliveryCount.Enabled = false;
                txtFee1.Text = productDelivery.Fee1.ToString();
                dtpDeliveryDate.Date = productDelivery.DeliveryDate;
                txtReceiptNum.Text = productDelivery.ReceiptNum;
                txtDescription.Text = productDelivery.Description;

                dtpInputInvoiceDate.Date = productDelivery.InputInvoiceDate;
                txtInputInvoiceRow.Text = productDelivery.InputInvoiceRow;
                txtInputInvoiceNum.Text = productDelivery.InputInvoiceNum;
                txtInputInvoiceCost.Text = productDelivery.InputInvoiceCost.ToString();

                dtpOutputInvoiceDate.Date = productDelivery.OutputInvoiceDate;
                txtOutputInvoiceRow.Text = productDelivery.OutputInvoiceRow;
                txtOutputInvoiceNum.Text = productDelivery.OutputInvoiceNum;
                txtOutputInvoiceCost.Text = productDelivery.OutputInvoiceCost.ToString();

                BindLabels();

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
                    var productDelivery = _productDeliveryFactory.GetAllBy(ProductDelivery.ProductDeliveryFields.Id, id)[0];

                    var lstCartext = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.Id, productDelivery.CartexId);
                    lstCartext[0].Stock += productDelivery.DeliveryCount;
                    _cartexesFactory.Update(lstCartext[0]);


                    _productDeliveryFactory.Delete(ProductDelivery.ProductDeliveryFields.Id, id);

                    var message = "تحویل محصول برای کارتکس با نام کار  " + lblJobName.Text + " حذف گردید";
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
            cmbDeliveryReceivers.SelectedIndex = 0;
            txtDeliveryCount.Text = "";
            txtDeliveryCount.Enabled = true;
            txtFee1.Text = "";
            dtpDeliveryDate.Date = null;
            txtReceiptNum.Text = "";
            txtDescription.Text = "";

            dtpInputInvoiceDate.Date = null;
            txtInputInvoiceRow.Text = "";
            txtInputInvoiceNum.Text = "";
            txtInputInvoiceCost.Text = "";

            dtpOutputInvoiceDate.Date = null;
            txtOutputInvoiceRow.Text = "";
            txtOutputInvoiceNum.Text = "";
            txtOutputInvoiceCost.Text = "";

            lblCostSum1.Text = "";
            lblCostSum2.Text = "";
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
            var lstProductDelivery = _productDeliveryFactory.GetAllBy(ProductDelivery.ProductDeliveryFields.Id, ItemId);
            if (lstProductDelivery.Count > 0)
            {
                if (int.Parse(cmbDeliveryReceivers.SelectedValue) != 0)
                {
                    lstProductDelivery[0].DeliveryReceiversId = int.Parse(cmbDeliveryReceivers.SelectedValue);
                }
                else
                {
                    lstProductDelivery[0].DeliveryReceiversId = null;
                }
                lstProductDelivery[0].DeliveryCount = int.Parse(txtDeliveryCount.Text);
                lstProductDelivery[0].Fee1 = decimal.Parse(txtFee1.Text);
                lstProductDelivery[0].DeliveryDate = dtpDeliveryDate.Date.Value;
                lstProductDelivery[0].ReceiptNum = txtReceiptNum.Text;
                lstProductDelivery[0].Description = txtDescription.Text;

                lstProductDelivery[0].InputInvoiceDate = dtpInputInvoiceDate.Date;
                lstProductDelivery[0].InputInvoiceRow = txtInputInvoiceRow.Text;
                lstProductDelivery[0].InputInvoiceNum = txtInputInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtInputInvoiceCost.Text))
                    lstProductDelivery[0].InputInvoiceCost = decimal.Parse(txtInputInvoiceCost.Text);

                lstProductDelivery[0].OutputInvoiceDate = dtpOutputInvoiceDate.Date;
                lstProductDelivery[0].OutputInvoiceRow = txtOutputInvoiceRow.Text;
                lstProductDelivery[0].OutputInvoiceNum = txtOutputInvoiceNum.Text;
                if (!string.IsNullOrEmpty(txtOutputInvoiceCost.Text))
                    lstProductDelivery[0].OutputInvoiceCost = decimal.Parse(txtOutputInvoiceCost.Text);


                _productDeliveryFactory.Update(lstProductDelivery[0]);

                var message = "تحویل محصول برای کارتکس با نام کار  " + lblJobName.Text + " ویرایش گردید";
                WriteOperation(message);

                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewProductDelivery_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewProductDelivery.PageIndex = e.NewPageIndex;
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

        protected void txtDeliveryCount_TextChanged(object sender, EventArgs e)
        {
            BindLabels();
        }
    }
}