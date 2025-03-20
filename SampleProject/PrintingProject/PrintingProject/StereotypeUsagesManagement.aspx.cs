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
    public partial class StereotypeUsagesManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        StereotypeUsages _stereotypeUsages = new StereotypeUsages();
        StereotypeUsagesFactory _stereotypeUsagesFactory = new StereotypeUsagesFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "StereotypeUsagesManagement.aspx"))
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
            var lstStereotypeUsages = _stereotypeUsagesFactory.GetAll();
            grdviewStereotypeUsages.DataSource = lstStereotypeUsages;
            grdviewStereotypeUsages.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _stereotypeUsages.Name = txtName.Text;
            _stereotypeUsagesFactory.Insert(_stereotypeUsages);

          
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
                var stereotypeUsage = _stereotypeUsagesFactory.GetAllBy(StereotypeUsages.StereotypeUsagesFields.Id, id);
                txtName.Text = stereotypeUsage[0].Name;
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
                    _stereotypeUsagesFactory.Delete(StereotypeUsages.StereotypeUsagesFields.Id, id);
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
            var lstStereotypeUsages = _stereotypeUsagesFactory.GetAllBy(StereotypeUsages.StereotypeUsagesFields.Id, ItemId);
            if (lstStereotypeUsages.Count > 0)
            {
                lstStereotypeUsages[0].Name = txtName.Text;

                _stereotypeUsagesFactory.Update(lstStereotypeUsages[0]);

              
                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }

        

        protected void grdviewStereotypeUsages_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewStereotypeUsages.PageIndex = e.NewPageIndex;
            BindGrid();
        }
    }
}