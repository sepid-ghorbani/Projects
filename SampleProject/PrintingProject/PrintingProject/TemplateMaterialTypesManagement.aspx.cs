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
    public partial class TemplateMaterialTypesManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        TemplateMaterialTypes _templateMaterialTypes = new TemplateMaterialTypes();
        TemplateMaterialTypesFactory _templateMaterialTypesFactory = new TemplateMaterialTypesFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "TemplateMaterialTypesManagement.aspx"))
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
            var lstTemplateMaterialTypes = _templateMaterialTypesFactory.GetAll();
            grdviewTemplateMaterialTypes.DataSource = lstTemplateMaterialTypes;
            grdviewTemplateMaterialTypes.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _templateMaterialTypes.Name = txtName.Text;
            _templateMaterialTypesFactory.Insert(_templateMaterialTypes);



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
                var templateMaterialType = _templateMaterialTypesFactory.GetAllBy(TemplateMaterialTypes.TemplateMaterialTypesFields.Id, id);
                txtName.Text = templateMaterialType[0].Name;
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
                    _templateMaterialTypesFactory.Delete(TemplateMaterialTypes.TemplateMaterialTypesFields.Id, id);
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
            var lstTemplateMaterialTypes = _templateMaterialTypesFactory.GetAllBy(TemplateMaterialTypes.TemplateMaterialTypesFields.Id, ItemId);
            if (lstTemplateMaterialTypes.Count > 0)
            {
                lstTemplateMaterialTypes[0].Name = txtName.Text;

                _templateMaterialTypesFactory.Update(lstTemplateMaterialTypes[0]);


                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }


        protected void grdviewTemplateMaterialTypes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewTemplateMaterialTypes.PageIndex = e.NewPageIndex;
            BindGrid();
        }
    }
}