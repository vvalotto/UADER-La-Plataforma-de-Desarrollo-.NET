<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IronManWebMVP.aspx.cs" Inherits="IronManWebMVP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1
        {
            width: 66%;
        }
        .auto-style2
        {
            width: 342px;
        }
        .auto-style3
        {
            width: 115px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:ListBox ID="listBoxEventos" 
                           runat="server" Height="162px" 
                           Width="300px" AutoPostBack="true"
                           OnSelectedIndexChanged="listBoxEventos_SelectedIndexChanged" >
                    </asp:ListBox>
                </td>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label1" runat="server" Text="Nombre" ></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtNombre" runat="server" Width="372px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Lugar</td>
                            <td>
                                <asp:TextBox ID="txtLugar" runat="server" Width="373px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Fecha</td>
                            <td>
                                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Comentario</td>
                            <td>
                                <asp:TextBox ID="txtComentario" runat="server" Width="377px" Height="132px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
