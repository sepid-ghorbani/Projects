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
    public partial class DeliveryReceiversManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        DeliveryReceivers _deliveryReceivers = new DeliveryReceivers();
        DeliveryReceiversFactory _deliveryReceiversFactory = new DeliveryReceiversFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "DeliveryReceiversManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }
                BindGrid();
                ClearFrom();
                ChangeButtonsEnable("Normal");

            }
        }
        private void BindGrid()
        {
            var lstDeliveryReceivers = _deliveryReceiversFactory.GetAll();
            grdviewDeliveryReceivers.DataSource = lstDeliveryReceivers;
            grdviewDeliveryReceivers.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _deliveryReceivers.Name = txtName.Text;
            _deliveryReceiversFactory.Insert(_deliveryReceivers);


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
                var deliveryReceiver = _deliveryReceiversFactory.GetAllBy(DeliveryReceivers.DeliveryReceiversFields.Id, id);
                txtName.Text = deliveryReceiver[0].Name;
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
                    _deliveryReceiversFactory.Delete(DeliveryReceivers.DeliveryReceiversFields.Id, id);
                    BindGrid();
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "اطلاعات با موفقیت حذف گردید.";
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
            txtName.Text = "";
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
            var lstDeliveryReceiver = _deliveryReceiversFactory.GetAllBy(DeliveryReceivers.DeliveryReceiversFields.Id, ItemId);
            if (lstDeliveryReceiver.Count > 0)
            {
                lstDeliveryReceiver[0].Name = txtName.Text;

                _deliveryReceiversFactory.Update(lstDeliveryReceiver[0]);


                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewDeliveryReceivers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewDeliveryReceivers.PageIndex = e.NewPageIndex;
            BindGrid();
        }
    }
}