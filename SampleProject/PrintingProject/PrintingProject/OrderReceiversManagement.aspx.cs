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
    public partial class OrderReceiversManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        OrderReceivers _orderReceivers = new OrderReceivers();
        OrderReceiversFactory _orderReceiversFactory = new OrderReceiversFactory();

        LevelOrderReceiver _levelOrderReceiver = new LevelOrderReceiver();
        LevelOrderReceiverFactory _levelOrderReceiverFactory = new LevelOrderReceiverFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "OrderReceiversManagement.aspx"))
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
            var lstOrderReceivers = _orderReceiversFactory.GetAll();
            grdviewOrderReceivers.DataSource = lstOrderReceivers;
            grdviewOrderReceivers.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<ListItem> selected = chkBoxLevels.Items.Cast<ListItem>().Where(item => item.Selected).ToList();
            if (selected.Count == 0)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "بخشی برای این سفارش گیرنده انتخاب نشده است.";
            }
            else
            {
                _orderReceivers.Name = txtName.Text;
                _orderReceiversFactory.Insert(_orderReceivers);

                foreach (ListItem item in chkBoxLevels.Items)
                {
                    if (item.Selected)
                    {
                        _levelOrderReceiver.OrderReceiver_Id = _orderReceivers.Id;
                        _levelOrderReceiver.Level_Id = int.Parse(item.Value);
                        _levelOrderReceiverFactory.Insert(_levelOrderReceiver);
                    }
                }

                
                ClearFrom();
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ثبت گردید.";
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
            ClearFrom();
            var btn = sender as ImageButton;
            if (btn != null)
            {
                int id = int.Parse(btn.CssClass);
                ItemId = id;
                ChangeButtonsEnable("Edit");
                var orderReceivers = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id, id);
                var levels =
                    _levelOrderReceiverFactory.GetAllBy(LevelOrderReceiver.LevelOrderReceiverFields.OrderReceiver_Id,
                                                        orderReceivers[0].Id);
                foreach (var level in levels)
                {
                    foreach (ListItem item in chkBoxLevels.Items)
                    {
                        if (int.Parse(item.Value) == level.Level_Id)
                            item.Selected = true;
                    }
                }
                txtName.Text = orderReceivers[0].Name;

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
                    _levelOrderReceiverFactory.Delete(LevelOrderReceiver.LevelOrderReceiverFields.OrderReceiver_Id, id);
                    _orderReceiversFactory.Delete(OrderReceivers.OrderReceiversFields.Id, id);
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
            txtName.Text = "";
            foreach (ListItem item in chkBoxLevels.Items)
            {
                item.Selected = false;
            }
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
            var lstOrderReceivers = _orderReceiversFactory.GetAllBy(OrderReceivers.OrderReceiversFields.Id, ItemId);
            if (lstOrderReceivers.Count > 0)
            {
                List<ListItem> selected = chkBoxLevels.Items.Cast<ListItem>().Where(item => item.Selected).ToList();
                if (selected.Count == 0)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "بخشی برای این سفارش گیرنده انتخاب نشده است.";
                }
                else
                {
                    lstOrderReceivers[0].Name = txtName.Text;
                    _orderReceiversFactory.Update(lstOrderReceivers[0]);

                    _levelOrderReceiverFactory.Delete(LevelOrderReceiver.LevelOrderReceiverFields.OrderReceiver_Id, lstOrderReceivers[0].Id);

                    foreach (ListItem item in chkBoxLevels.Items)
                    {
                        if (item.Selected)
                        {
                            _levelOrderReceiver.OrderReceiver_Id = lstOrderReceivers[0].Id;
                            _levelOrderReceiver.Level_Id = int.Parse(item.Value);
                            _levelOrderReceiverFactory.Insert(_levelOrderReceiver);
                        }
                    }


                   

                    ClearFrom();
                    ChangeButtonsEnable("Normal");
                    BindGrid();
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
                }



            }
        }

       

        protected void grdviewOrderReceivers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewOrderReceivers.PageIndex = e.NewPageIndex;
            BindGrid();
        }
    }
}