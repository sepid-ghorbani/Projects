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
    public partial class UserManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        Users _users = new Users();
        UsersFactory _usersFactory = new UsersFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "UserManagement.aspx"))
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
            var lstUsers = _usersFactory.GetAll();
            grdviewUsers.DataSource = lstUsers;
            grdviewUsers.DataBind();
        }
        protected void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (txtboxUserName.Text != string.Empty)
            {
                var lstuser = _usersFactory.GetAllBy(Users.UsersFields.UserName, txtboxUserName.Text.Trim());
                if (lstuser.Count > 0)
                {
                    img.ImageUrl = "Images/dialog_cancel.png";
                    img.Visible = true;
                }
                else
                {
                    img.Visible = true;
                    img.ImageUrl = "Images/tick.png";
                }
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (img.ImageUrl != "Images/dialog_cancel.png")
            {
                _users.Name = txtName.Text;
                _users.UserName = txtboxUserName.Text;
                _users.Password = txtboxPassword.Text;
                _users.CreateDate = DateTime.Now;
                _users.Enable = chkEnable.Checked;
                _users.Email = txtEmail.Text;
                _users.Mobile = txtMobile.Text;

                _usersFactory.Insert(_users);

               
                ClearFrom();
                BindGrid();
                img.Visible = false;

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ثبت گردید.";

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeButtonsEnable("Normal");
            txtboxUserName.Enabled = true;
            img.Visible = false;
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
                var user = _usersFactory.GetAllBy(Users.UsersFields.Id, id);
                txtName.Text = user[0].Name;
                txtboxUserName.Text = user[0].UserName;
                txtboxPassword.Text = user[0].Password;
                txtConfirmPassword.Text = user[0].Password;
                txtEmail.Text = user[0].Email;
                chkEnable.Checked = user[0].Enable;
                txtMobile.Text = user[0].Mobile;
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
                    _usersFactory.Delete(Users.UsersFields.Id, id);
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
            txtboxUserName.Text = "";
            txtboxPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            chkEnable.Checked = false;
            img.ImageUrl = "";
            lblCheckmail.Text = "";
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
            var lstuser = _usersFactory.GetAllBy(Users.UsersFields.Id, ItemId);
            if (lstuser.Count > 0)
            {
                lstuser[0].Name = txtName.Text;
                if (txtboxPassword.Text != string.Empty)
                    lstuser[0].Password = txtboxPassword.Text;
                lstuser[0].Enable = chkEnable.Enabled;
                lstuser[0].Email = txtEmail.Text;
                lstuser[0].Mobile = txtMobile.Text;

                _usersFactory.Update(lstuser[0]);

               
                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
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

        protected void grdviewUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewUsers.PageIndex = e.NewPageIndex;
            BindGrid();
        }

    }
}