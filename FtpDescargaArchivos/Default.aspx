<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FtpDescargaArchivos.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Ftp Descarga de Archivos</h1>
            <br />
            <input type="text" runat="server" name="archivo" id="archivo" placeholder="Nombre del Archivo" />
            <br />
            <asp:Button ID="btnDownload" runat="server" Text="Descargar Archivo" OnClick="btnDownload_Click"/>
        </div>
    </form>
</body>
</html>
