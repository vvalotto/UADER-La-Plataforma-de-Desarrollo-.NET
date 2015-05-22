<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            width: 319px;
            height: 23px;
        }
        .auto-style3
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" ForeColor="#CC00FF" Font-Size ="XX-Large"
                         
                         Text="IronMan"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Image ID="Image1" runat="server" ImageAlign="Middle" ImageUrl="~/Imagenes/maraton.jpeg" />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:HyperLink ID="HyperLink1" NavigateURL="~/ListaEventos.aspx" runat="server">Mostrar Eventos</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateURL="~/Evento.aspx?eID=0" runat="server">Agregar Nuevo Evento</asp:HyperLink>
    </form>
</body>
</html>
