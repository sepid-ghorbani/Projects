<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrintPreviewPage.aspx.cs"
    Inherits="PrintingProject.PrintPreviewPage" %>


<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=10.2.16.1025, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 100%;" align="center">
        <telerik:ReportViewer ID="ReportViewer1"  Width="80%" runat="server"  
            Height="800px" ProgressText="در حال آماده سازی" ZoomPercent="20" 
            Skin="Office2007" ViewMode="PrintPreview"></telerik:ReportViewer>
    </div>
    </form>
</body>
</html>
