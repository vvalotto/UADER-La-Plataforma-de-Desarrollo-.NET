<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MENU</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div align="center"> Menu </div>
        <ul>
            <li>
                <asp:HyperLink ID="hlFormulario" 
                               runat="server"
                               Text="Formulario"
                               NavigateUrl="~/Default.aspx"/>
            </li>
            <li>
                <asp:HyperLink ID="hlPagina1" 
                               runat="server"
                               Text="Pagina 1"
                               NavigateUrl="~/Pagina1.aspx"/>
            </li>
            <li>
                <asp:HyperLink ID="hlCliente" 
                               runat="server"
                               Text="Cliente"
                               NavigateUrl="~/Cliente/Cliente.aspx"/>
            </li>
        </ul>
        </div>
        <div align="right">
            <asp:Label ID="lbVersion" 
                       runat="server" />
        </div>
    </form>
</body>
</html>
