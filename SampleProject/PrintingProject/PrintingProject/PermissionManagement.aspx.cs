using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingProject.BusinessLayer;

namespace PrintingProject
{
    public partial class PermissionManagement : System.Web.UI.Page
    {
        PagesFactory _pagesFactory = new PagesFactory();
        UsersFactory _usersFactory = new UsersFactory();
        UserPageFactory _userPageFactory = new UserPageFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindCmbUsers();
                var lstpages = _pagesFactory.GetAll();
                grdviewPages.DataSource = lstpages;
                grdviewPages.DataBind();
                FillGrid();
                lblMessage.Text = "";

            }
        }
        private void BindCmbUsers()
        {
            var users = _usersFactory.GetAll();
            cmbUsers.DataSource = users;
            cmbUsers.DataTextField = "Name";
            cmbUsers.DataValueField = "Id";
            cmbUsers.DataBind();
        }
        private void FillGrid()
        {
            for (int i = 0; i < grdviewPages.Rows.Count; i++)
            {
                if (grdviewPages.Rows[i].RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkboxSelect = (CheckBox)grdviewPages.Rows[i].FindControl("chkboxSelect");
                    var userPages = _userPageFactory.GetByUserIdPageId(int.Parse(cmbUsers.SelectedValue), int.Parse(chkboxSelect.CssClass));
                    if (userPages.Count > 0)
                    {
                        chkboxSelect.Checked = true;
                    }
                    else
                    {
                        chkboxSelect.Checked = false;
                    }
                }
            }
        }

        protected void btnSavePermissions_Click(object sender, EventArgs e)
        {
            _userPageFactory.Delete(UserPage.UserPageFields.User_Id, int.Parse(cmbUsers.SelectedValue));
            for (int i = 0; i < grdviewPages.Rows.Count; i++)
            {
                if (grdviewPages.Rows[i].RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkboxSelect = (CheckBox)grdviewPages.Rows[i].FindControl("chkboxSelect");
                    if (chkboxSelect.Checked == true)
                    {
                        var up = new UserPage();
                        up.User_Id = int.Parse(cmbUsers.SelectedValue);
                        up.Page_Id = int.Parse(chkboxSelect.CssClass);
                        _userPageFactory.Insert(up);
                    }
                }
            }
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "سطح دسترسی با موفقیت تعیین شد.";
        }

        protected void cmbUsers_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            FillGrid();
            lblMessage.Text = "";
        }
    }
}