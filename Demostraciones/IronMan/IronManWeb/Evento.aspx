<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Evento.aspx.cs" Inherits="Evento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 59%;
            background-color:azure;
        }
        .auto-style2
        {
            width: 232px;
        }
        .auto-style3
        {
            width: 232px;
            height: 140px;
        }
        .auto-style4
        {
            height: 140px;
            width: 625px;
        }
        .auto-style6
        {
            width: 625px;
        }
        .auto-style10
        {
            width: 232px;
            height: 45px;
        }
        .auto-style11
        {
            width: 625px;
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:ValidationSummary ID="vsEvento"
            align="Left" 
            runat="server" 
            BackColor="#FFCCFF" 
            ValidationGroup="EventoValidador" />
    
        <table class="auto-style1" border="1">
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblNombre" 
                         runat="server"  
                         Text="Nombre"/>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtNombre" 
                        runat="server" 
                        Width="500px"/>
                    <asp:RequiredFieldValidator ID ="rfvNombre"
                         runat="server"
                         Display="Dynamic"
                         ForeColor="Red"
                         ValidationGroup="EventoValidador"
                         ControlToValidate="txtNombre" ErrorMessage="Por favor Ingrese el nombre"
                        >*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblLugar" runat="server" Text="Lugar"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtLugar" 
                        runat="server" 
                        Width="500px"/>
                    <asp:RequiredFieldValidator ID ="rfvLugar"
                         runat="server"
                         Display="Dynamic"
                         ForeColor="Red"
                         ValidationGroup="EventoValidador"
                         ControlToValidate="txtNombre" ErrorMessage="Por favor Ingrese el Lugar"
                        >*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblFecha" runat="server" Text="Fecha"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtFecha" 
                        runat="server" 
                        TextMode="Date"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"> 
                    <asp:Label ID="lblComentario" runat="server" Text="Comentario">
                    </asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtComentario" 
                        runat="server" 
                        Height="125px" 
                        TextMode="MultiLine" 
                        Width="500px"/>
                    <asp:RequiredFieldValidator ID ="rfvComentario"
                         runat="server"
                         Display="Dynamic"
                         ForeColor="Red"
                         ValidationGroup="EventoValidador"
                         ControlToValidate="txtComentario" ErrorMessage="Por favor ingreso un comentario"
                        >*</asp:RequiredFieldValidator>
                </td>
            </tr>
            </table>
    
    </div>
        <div align="center">
            <asp:Button ID="btnCancelar" 
                runat="server" 
                Text="Cancelar" 
                CausesValidation="false"/>
            <asp:Button ID="btnGuardar" 
                runat="server" 
                Text="Guardar" 
                ValidationGroup="EventoValidador"
                onclick="btnGuardar_Click"/>
         </div>
    </form>
    <div align="center">
        <p><a href="Default.aspx">Home</a></p>
        <p><a href="ListaEventos.aspx">Lista de Eventos</a></p>
    </div>
</body>
</html>
