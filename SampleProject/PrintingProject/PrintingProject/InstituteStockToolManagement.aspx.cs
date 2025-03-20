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
    public partial class InstituteStockToolManagement : System.Web.UI.Page
    {
        MaterialTypesFactory _materialTypesFactory = new MaterialTypesFactory();
        MaterialTypeGramazhFactory _materialTypeGramazhFactory = new MaterialTypeGramazhFactory();
        PaperWidthFactory _paperWidthFactory = new PaperWidthFactory();
        PaperHeightFactory _paperHeightFactory = new PaperHeightFactory();
        InstituteFactory _instituteFactory = new InstituteFactory();
        StockFactory _stockFactory = new StockFactory();

        UserPageFactory _userPageFactory = new UserPageFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "InstituteStockToolManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;  Response.Redirect("Login.aspx");
                }
                Bindcmb();

            }
        }
        private void Bindcmb()
        {
            var lstInstitute = _instituteFactory.GetAll();
            var institute = new Institute()
            {
                Id = 0,
                Name = "همه موارد"
            };
            lstInstitute.Insert(0,institute);
            cmbInstitute.DataSource = lstInstitute;
            cmbInstitute.DataBind();

            var lstMaterialType = _materialTypesFactory.GetAll();
            cmbMaterialType.DataSource = lstMaterialType;
            cmbMaterialType.DataBind();

            var lstMaterialTypeGramazh = _materialTypeGramazhFactory.GetAll();
            cmbMaterialTypeGramazh.DataSource = lstMaterialTypeGramazh;
            cmbMaterialTypeGramazh.DataBind();

            var lstPaperWidth = _paperWidthFactory.GetAll();
            cmbPaperWidth.DataSource = lstPaperWidth;
            cmbPaperWidth.DataBind();

            var lstPaperHeight = _paperHeightFactory.GetAll();
            cmbPaperHeight.DataSource = lstPaperHeight;
            cmbPaperHeight.DataBind();
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int instituteId = int.Parse(cmbInstitute.SelectedValue);
            int materialTypeId = int.Parse(cmbMaterialType.SelectedValue);
            int materialTypeGramazhId = int.Parse(cmbMaterialTypeGramazh.SelectedValue);
            int paperWidthId = int.Parse(cmbPaperWidth.SelectedValue);
            int paperHeightId = int.Parse(cmbPaperHeight.SelectedValue);

            var stock = _stockFactory.GetStockOfInstitute(instituteId, materialTypeId, materialTypeGramazhId,
                                                          paperWidthId, paperHeightId);
            //lblStock.Text = string.Format("{0:#,###0}", stock);
            grdviewStock.DataSource = stock;
            grdviewStock.DataBind();
        }


    }
}