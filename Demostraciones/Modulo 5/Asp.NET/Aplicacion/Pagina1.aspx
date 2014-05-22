<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina1.aspx.cs" Inherits="Pagina1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PAGINA 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnServerTransfer" 
                        runat="server" 
                        Text="Volver usando Server Transfer" 
                onclick="btnServerTransfer_Click" />
        </div>
        <div align="right">
            <asp:Label ID="lbVersion" 
                       runat="server" />
        </div>
    </form>
</body>
</html>
