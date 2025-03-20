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
    public partial class InstituteManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        Institute _institute = new Institute();
        InstituteFactory _instituteFactory = new InstituteFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "InstituteManagement.aspx"))
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
            var lstInstitute = _instituteFactory.GetAll();
            grdviewInstitute.DataSource = lstInstitute;
            grdviewInstitute.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            _institute.Name = txtName.Text;
            _instituteFactory.Insert(_institute);

          
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
                var institute = _instituteFactory.GetAllBy(Institute.InstituteFields.Id, id);
                txtName.Text = institute[0].Name;
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
                    _instituteFactory.Delete(Institute.InstituteFields.Id, id);
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
            var lstInstitute = _instituteFactory.GetAllBy(Institute.InstituteFields.Id, ItemId);
            if (lstInstitute.Count > 0)
            {
                lstInstitute[0].Name = txtName.Text;

                _instituteFactory.Update(lstInstitute[0]);

              
                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }

      

        protected void grdviewInstitute_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewInstitute.PageIndex = e.NewPageIndex;
            BindGrid();
        }
    }
}