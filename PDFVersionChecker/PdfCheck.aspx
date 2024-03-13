<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PdfCheck.aspx.cs" Inherits="PDFVersionChecker.PdfCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fileUpload" runat="server" />
            <asp:Button ID="btnDownload" runat="server" Text="Validate" OnClick="btnDownload_Click" />
        </div>
    </form>
</body>
</html>
