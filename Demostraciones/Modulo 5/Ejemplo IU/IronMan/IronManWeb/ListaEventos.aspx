<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListaEventos.aspx.cs" Inherits="ListaEventos" %>

<!DOCTYPE html>
<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            font-size: xx-large;
            text-align: center;
            background-color: #99CCFF;
        }
        .auto-style4
        {
            width: 100%;
        }
        .auto-style5
        {
            text-align: center;
        }
        .auto-style6
        {
            height: 12px;
            background-color: lightgray;
        }
        .auto-style7
        {
            background-color: #FFFFFF;
        }
        .auto-style8
        {
            font-size: xx-large;
            text-align: center;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table class="auto-style4">
            <tr>
                <td class="auto-style5">
                    <strong><span class="auto-style8">IronMan</span>
                            <span class="auto-style1">
                             <br class="auto-style7" /></span>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" align ="center" >Lista de Eventos</td>
            </tr>
        </table>
    </div>
    <div align="center">
        <asp:GridView ID="dgListaEventos" runat="server" 
            BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" ForeColor="Black" GridLines="Vertical" 
            OnRowCreated="dgListaEventos_RowCreated" AutoGenerateEditButton="True">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White"/>
            <PagerSettings FirstPageText="First" LastPageText="Last" PageButtonCount="4" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="Blue" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </div>
    </form>
    <div>
            <p align="center"><a href="Default.aspx">Home</a></p>
            <p align="center"><a href="Evento.aspx">Nuevo Evento</a></p>
    </div>
</body>
</html>
