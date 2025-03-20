using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOpenXml;
using Telerik.Web.UI;
using System.Web.Script.Serialization;
using PrintingProject.BusinessLayer;


namespace PrintingProject
{
    public partial class JobNamesManagement : System.Web.UI.Page
    {
        public int ItemId { get { return (int)ViewState["ItemId"]; } set { ViewState["ItemId"] = value; } }
        JobNames _jobNames = new JobNames();
        JobNamesFactory _jobNamesFactory = new JobNamesFactory();
        CustomersFactory _customersFactory = new CustomersFactory();
        JobsFactory _jobsFactory = new JobsFactory();
        UserPageFactory _userPageFactory = new UserPageFactory();
        CartexesFactory _cartexesFactory = new CartexesFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "JobNamesManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }
                BindCmb();
                BindGrid();
                ClearFrom();
                ChangeButtonsEnable("Normal");

            }
        }
        private void BindCmb()
        {
            var lstCustomers = _customersFactory.GetAll();
            cmbCustomers.DataSource = lstCustomers;
            cmbCustomers.DataBind();

            cmbCustomersManual.DataSource = lstCustomers;
            cmbCustomersManual.DataBind();

        }
        private void BindGrid()
        {
            var lstInstitute = _jobNamesFactory.GetAllForGrid();
            grdviewJobNames.DataSource = lstInstitute;
            grdviewJobNames.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            _jobNames.Code = txtCode.Text;
            _jobNames.Name = txtName.Text;
            _jobNames.StoreCode = int.Parse(txtStoreCode.Text);
            _jobNames.CustomerId = int.Parse(cmbCustomersManual.SelectedValue);
            _jobNames.Fee1 = decimal.Parse(txtFee1.Text);
            _jobNames.Fee2 = decimal.Parse(txtFee2.Text);

            _jobNamesFactory.Insert(_jobNames);


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
                var jobNames = _jobNamesFactory.GetAllBy(JobNames.JobNamesFields.Id, id);
                cmbCustomersManual.SelectedValue = jobNames[0].CustomerId.ToString();
                txtCode.Text = jobNames[0].Code;
                txtName.Text = jobNames[0].Name;
                txtStoreCode.Text = jobNames[0].StoreCode.ToString();
                txtFee1.Text = jobNames[0].Fee1.ToString();
                txtFee2.Text = jobNames[0].Fee2.ToString();
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
                    _jobNamesFactory.Delete(JobNames.JobNamesFields.Id, id);
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
            txtCode.Text = "";
            txtName.Text = "";
            txtStoreCode.Text = "";
            cmbCustomers.SelectedIndex = 0;
            txtFee1.Text = "";
            txtFee2.Text = "";
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
            var lstJobNames = _jobNamesFactory.GetAllBy(JobNames.JobNamesFields.Id, ItemId);
            if (lstJobNames.Count > 0)
            {
                lstJobNames[0].Code = txtCode.Text;
                lstJobNames[0].Name = txtName.Text;
                lstJobNames[0].StoreCode = int.Parse(txtStoreCode.Text);
                lstJobNames[0].CustomerId = int.Parse(cmbCustomersManual.SelectedValue);
                lstJobNames[0].Fee1 = decimal.Parse(txtFee1.Text);
                lstJobNames[0].Fee2 = decimal.Parse(txtFee2.Text);
                _jobNamesFactory.Update(lstJobNames[0]);


                ClearFrom();
                ChangeButtonsEnable("Normal");
                BindGrid();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "اطلاعات با موفقیت ویرایش گردید.";
            }
        }
        protected void grdviewJobNames_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewJobNames.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void btnReadExcel_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile && Path.GetExtension(FileUpload1.FileName) == ".xlsx")
            {
                using (var excel = new ExcelPackage(FileUpload1.PostedFile.InputStream))
                {
                    var tbl = new DataTable();
                    var ws = excel.Workbook.Worksheets.First();
                    var hasHeader = true;  // adjust accordingly
                    // add DataColumns to DataTable
                    foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                        tbl.Columns.Add(hasHeader ? firstRowCell.Text
                            : String.Format("Column {0}", firstRowCell.Start.Column));

                    // add DataRows to DataTable
                    int startRow = hasHeader ? 2 : 1;
                    for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                    {
                        var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                        DataRow row = tbl.NewRow();
                        foreach (var cell in wsRow)
                            row[cell.Start.Column - 1] = cell.Text;
                        tbl.Rows.Add(row);
                    }

                    foreach (DataRow dtRow in tbl.Rows)
                    {
                        int storeCode = int.Parse(dtRow[2].ToString());
                        var lstjob = _jobNamesFactory.GetAllBy(JobNames.JobNamesFields.StoreCode, storeCode);
                        if (lstjob.Count > 0)
                        {
                            lstjob[0].Code = dtRow[0].ToString();
                            lstjob[0].Name = dtRow[1].ToString();
                            lstjob[0].CustomerId = int.Parse(cmbCustomers.SelectedValue);
                            lstjob[0].Fee2 = decimal.Parse(dtRow[3].ToString());
                            lstjob[0].Fee1 = decimal.Parse(dtRow[4].ToString());

                            _jobNamesFactory.Update(lstjob[0]);
                        }
                        else
                        {
                            _jobNames.Code = dtRow[0].ToString();
                            _jobNames.Name = dtRow[1].ToString();
                            _jobNames.StoreCode = storeCode;
                            _jobNames.CustomerId = int.Parse(cmbCustomers.SelectedValue);
                            _jobNames.Fee2 = decimal.Parse(dtRow[3].ToString());
                            _jobNames.Fee1 = decimal.Parse(dtRow[4].ToString());
                            _jobNamesFactory.Insert(_jobNames);
                        }

                        var lstMainjob = _jobsFactory.GetAllBy(Jobs.JobsFields.StoreCode, storeCode);
                        if (lstMainjob.Count > 0)
                        {
                            lstMainjob[0].Code = dtRow[0].ToString();
                            lstMainjob[0].Name = dtRow[1].ToString();
                            lstMainjob[0].CustomerId = int.Parse(cmbCustomers.SelectedValue);

                            _jobsFactory.Update(lstMainjob[0]);
                        }
                        var lstCartex = _cartexesFactory.GetAllBy(Cartexes.CartexesFields.StoreCode, storeCode);
                        if (lstCartex.Count > 0)
                        {
                            lstCartex[0].JobCode = dtRow[0].ToString();
                            lstCartex[0].JobName = dtRow[1].ToString();
                            lstCartex[0].CustomerId = int.Parse(cmbCustomers.SelectedValue);

                            _cartexesFactory.Update(lstCartex[0]);
                        }

                    }
                    lblFileUploadMessage.ForeColor = Color.Green;
                    lblFileUploadMessage.Text = "فایل با موفقیت خوانده شد.";
                    BindGrid();

                }
            }
            else
            {
                lblFileUploadMessage.ForeColor = Color.Red;
                lblFileUploadMessage.Text = "فایل با فرمت اکسل را انتخاب نمایید.";
            }
        }
    }
}