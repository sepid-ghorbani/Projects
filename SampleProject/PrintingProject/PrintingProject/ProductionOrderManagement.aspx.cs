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
    public partial class ProductionOrderManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        public int OrderReceiverId { get { return (int)ViewState["OrderReceiverId"]; } set { ViewState["OrderReceiverId"] = value; } }
        public int JobTypesId { get { return (int)ViewState["JobTypesId"]; } set { ViewState["JobTypesId"] = value; } }

        ProductionOrder _productionOrder = new ProductionOrder();
        ProductionOrderFactory _productionOrderFactory = new ProductionOrderFactory();
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
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "ProductionOrderManagement.aspx"))
                {
                    PrintingProject.Session.IsLogin = false; Response.Redirect("Login.aspx");
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
            int cartexId = int.Parse(Request.QueryString["CId"]);
            var lstPrimaryStock = _primaryStockFactory.GetAllBy(PrimaryStock.PrimaryStockFields.CartexId, cartexId).OrderByDescending(x => x.Id).ToList();
            if (lstPrimaryStock.Count > 0)
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
            var lstPrimaryStock = _productionOrderFactory.GetAllForGrid(cartexId);
            grdviewProductionOrder.DataSource = lstPrimaryStock;
            grdviewProductionOrder.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblJobType.Text))
            {
                _productionOrder.CartexId = int.Parse(Request.QueryString["CId"]);
                _productionOrder.OrderReceiverId = OrderReceiverId;
                _productionOrder.JobTypesId = JobTypesId;
                _productionOrder.OrderDate = DateTime.Now;
                _productionOrder.OrderCount = int.Parse(txtOrderCount.Text);
                _productionOrder.Description = txtDescription.Text;

                _productionOrderFactory.Insert(_productionOrder);


                var message = "سفارش تولید برای کارتکس با نام کار  " + lblJobName.Text + " ایجاد گردید";
                WriteOperation(message);


                ClearFrom();
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
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

                var productionOrder = _productionOrderFactory.GetAllBy(ProductionOrder.ProductionOrderFields.Id, id)[0];
                txtOrderCount.Text = productionOrder.OrderCount.ToString();
                txtDescription.Text = productionOrder.Description;

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
                    var productionOrder = _productionOrderFactory.GetAllBy(ProductionOrder.ProductionOrderFields.Id, id);
                    if (_productionOrderFactory.HasPermissionToDelete(productionOrder[0].CartexId))
                    {
                        _productionOrderFactory.Delete(ProductionOrder.ProductionOrderFields.Id, id);

                        var message = "سفارش تولید برای کارتکس با نام کار  " + lblJobName.Text + " حذف گردید";
                        WriteOperation(message);

                        BindGrid();
                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "برای این سفارش, تحویل محصول ثبت شده است.";
                    }

                 
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
            txtOrderCount.Text = "";
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
            var lstProductionOrder = _productionOrderFactory.GetAllBy(ProductionOrder.ProductionOrderFields.Id, ItemId);
            if (lstProductionOrder.Count > 0)
            {
                lstProductionOrder[0].CartexId = int.Parse(Request.QueryString["CId"]);
                lstProductionOrder[0].OrderCount = int.Parse(txtOrderCount.Text);
                lstProductionOrder[0].Description = txtDescription.Text;


                _productionOrderFactory.Update(lstProductionOrder[0]);

                var message = "سفارش تولید برای کارتکس با نام کار  " + lblJobName.Text + " ویرایش گردید";
                WriteOperation(message);

                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewProductionOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewProductionOrder.PageIndex = e.NewPageIndex;
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