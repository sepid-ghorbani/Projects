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
    public partial class MaterialTypeGramazhManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        MaterialTypeGramazh _materialTypeGramazh = new MaterialTypeGramazh();
        MaterialTypeGramazhFactory _materialTypeGramazhFactory = new MaterialTypeGramazhFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "MaterialTypeGramazhManagement.aspx"))
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
            var lstMaterialTypeGramazh = _materialTypeGramazhFactory.GetAll();
            grdviewMaterialTypeGramazh.DataSource = lstMaterialTypeGramazh;
            grdviewMaterialTypeGramazh.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _materialTypeGramazh.Name = txtName.Text;
            _materialTypeGramazhFactory.Insert(_materialTypeGramazh);

         
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
                var materialTypeGramazh = _materialTypeGramazhFactory.GetAllBy(MaterialTypeGramazh.MaterialTypeGramazhFields.Id, id);
                txtName.Text = materialTypeGramazh[0].Name;
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
                    _materialTypeGramazhFactory.Delete(MaterialTypeGramazh.MaterialTypeGramazhFields.Id, id);
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
            var lstMaterialTypeGramazh = _materialTypeGramazhFactory.GetAllBy(MaterialTypeGramazh.MaterialTypeGramazhFields.Id, ItemId);
            if (lstMaterialTypeGramazh.Count > 0)
            {
                lstMaterialTypeGramazh[0].Name = txtName.Text;

                _materialTypeGramazhFactory.Update(lstMaterialTypeGramazh[0]);

              
                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }

       
       

        protected void grdviewMaterialTypeGramazh_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewMaterialTypeGramazh.PageIndex = e.NewPageIndex;
            BindGrid();
        }
    }
}