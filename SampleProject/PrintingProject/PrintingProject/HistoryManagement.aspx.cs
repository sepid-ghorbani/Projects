using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingProject.BusinessLayer;
using System.Data;
namespace PrintingProject
{
    public partial class HistoryManagement : System.Web.UI.Page
    {
        UserPageFactory _userPageFactory = new UserPageFactory();

        UsersFactory _usersFactory = new UsersFactory();
        Users _users = new Users();

        OperationHistoriesFactory _operationHistoriesFactory = new OperationHistoriesFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "BladeTypeManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }

                var lstUsers = _usersFactory.GetAll();

                _users.Id = 0;
                _users.Name = "همه موارد";
                lstUsers.Insert(0, _users);
                cmbUser.DataSource = lstUsers;
                cmbUser.DataBind();

            }
        }

        protected void btnshow_Click(object sender, EventArgs e)
        {
            int? userid = cmbUser.SelectedValue != "0" ? int.Parse(cmbUser.SelectedValue) : (int?)null;
            DateTime? startDate = dtpFromDate.Date;
            DateTime? endDate = dtpToDate.Date;
            string search = txtSearch.Text;

            DataTable dt = _operationHistoriesFactory.Search(userid, startDate, endDate, search);
            grdviewHistory.DataSource = dt;
            grdviewHistory.DataBind();


        }


    }
}