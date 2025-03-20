using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using PrintingProject.BusinessLayer;

namespace PrintingProject
{
    public partial class BackupManagement : System.Web.UI.Page
    {
        string zipfileaddress = string.Format("\\Backups\\files{0}.zip", DateTime.Now.ToFileTime());
        string UploadDirectoryAddress = "\\Restores";
        ZipOutputStream zipper;
        string FileName;
        string fullPath;
        string address;
        string file
        {
            set
            {
                ViewState["file"] = value;
            }
            get
            {
                if (ViewState["file"] == null) ViewState["file"] = "";
                return ViewState["file"].ToString();
            }
        }
        string database = "PrintingDB";
        BackupDeviceItem bdi;
        Backup backup;
        Restore restore;
        UserPageFactory _userPageFactory = new UserPageFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //if (RadUpload.UploadedFiles.Count > 0)
                //{
                //    FileName = string.Format("PrintingProject{0}.bak", DateTime.Now.ToFileTime());
                //    fullPath = "/Restores";
                //    fullPath = Server.MapPath(fullPath);
                //    if (!Directory.Exists(fullPath))
                //    {
                //        Directory.CreateDirectory(fullPath);
                //    }
                //    address = Path.Combine(fullPath, FileName);
                //    RadUpload.UploadedFiles[0].SaveAs(address);
                //}
            }
            else
            {
                if (!PrintingProject.Session.IsLogin)
                {
                    Response.Redirect("Login.aspx", false);
                }
                if (!_userPageFactory.HasPermission(PrintingProject.Session.UserId, "CustomersManagement.aspx"))
                {
                     PrintingProject.Session.IsLogin = false;
                     Response.Redirect("Login.aspx");
                }

            }
        }
        private void BackUp()
        {
            try
            {
                 FileName = string.Format("PrintingProject{0}.bak", DateTime.Now.ToFileTime());
                fullPath = "/Backups";
                address = Path.Combine(fullPath, FileName);
                fullPath = Server.MapPath(fullPath);
                if (!Directory.Exists(fullPath)) Directory.CreateDirectory(fullPath);
                var fileaddress = Path.Combine(fullPath, FileName);
                bdi = new BackupDeviceItem(fileaddress, DeviceType.File);
                backup = new Backup();
                backup.Database = database;
                backup.Devices.Add(bdi);
                backup.Initialize = true;

                // add percent complete and complete event handlers
                backup.PercentComplete +=
                    new PercentCompleteEventHandler(Backup_PercentComplete);

                Microsoft.SqlServer.Management.Smo.Server server = new Microsoft.SqlServer.Management.Smo.Server(new ServerConnection(new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.AppSettings["Main.ConnectionString"])));
                backup.SqlBackup(server);
                lblMessageBackup.ForeColor = Color.Green;
                lblMessageBackup.Text = "پشتیبان گیری از پایگاه داده با موفقیت انجام شد.";
            }
            catch (Exception ex)
            {
                lblMessageBackup.ForeColor = Color.Red;
                lblMessageBackup.Text = ex.Message;
            }
           


        }

        //private void Restore()
        //{
        //    try
        //    {
        //        bdi = new BackupDeviceItem(file, DeviceType.File);
        //        restore = new Restore();
        //        restore.Database = database;
        //        restore.Devices.Add(bdi);
        //        // restore.FileNumber = restoreFileNumber;
        //        restore.Action = RestoreActionType.Database;
        //        restore.ReplaceDatabase = true;
        //        // add percent complete and complete event handlers
        //        restore.PercentComplete +=
        //            new PercentCompleteEventHandler(Backup_PercentComplete);

        //        Microsoft.SqlServer.Management.Smo.Server server = new Microsoft.SqlServer.Management.Smo.Server(new ServerConnection(new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.AppSettings["Main.ConnectionString"])));
        //        Database db = server.Databases[database];
        //        db.SetOffline();
        //        restore.SqlRestore(server);
               

        //        db.SetOnline();
        //        server.Refresh();
        //        db.Refresh();

        //        lblMessageRestore.ForeColor = Color.Green;
        //        lblMessageRestore.Text = "اطلاعات با موفقیت بازیابی شد.";
        //    }
        //    catch (Exception)
        //    {

        //        lblMessageRestore.ForeColor = Color.Red;
        //        lblMessageRestore.Text = "بروز خطا در بازیابی اطلاعات";
        //    }
          

        //}

        protected void Backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            //btnRestore.Enabled = false;
           // hlkBackUp.Enabled = false;
        }

      

        protected void btnBackup_Click(object sender, EventArgs e)
        {
           // btnRestore.Enabled = false;
            BackUp();
            //hlkBackUp.Enabled = true;
            //hlkBackUp.NavigateUrl = string.Format("~{0}", address);
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
           // hlkBackUp.Enabled = false;
            //Restore();
           // btnRestore.Enabled = true;
        }
        protected void BackUpFiles()
        {
            string _zipfile = Server.MapPath(zipfileaddress);
            UploadDirectoryAddress = Server.MapPath(UploadDirectoryAddress);
            FileStream zipfile = System.IO.File.Create(_zipfile);
            // DirectoryInfo upload = new DirectoryInfo(UploadDirectoryAddress);
            zipper = new ZipOutputStream(zipfile);
            addZipEntry(UploadDirectoryAddress);
            zipper.Finish();
            zipper.Close();
        }

        protected void addZipEntry(string PathStr)
        {
            DirectoryInfo di = new DirectoryInfo(PathStr);
            foreach (DirectoryInfo item in di.GetDirectories())
            {
                addZipEntry(item.FullName);
            }
            foreach (FileInfo item in di.GetFiles())
            {
                FileStream fs = System.IO.File.OpenRead(item.FullName);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                string strEntryName = item.FullName.Replace(UploadDirectoryAddress + "\\", "");
                ZipEntry entry = new ZipEntry(strEntryName);
                zipper.PutNextEntry(entry);
                zipper.Write(buffer, 0, buffer.Length);
                fs.Close();
            }

        }

        

       

    }
}