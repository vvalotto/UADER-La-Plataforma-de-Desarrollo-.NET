<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SeguimientoEventos.aspx.cs" Inherits="SeguimientoEventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seguimiento de Eventos</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div>
            <h1>Controles que se monitorean por los eventos que surgen:</h1>
            <asp:TextBox ID="txt" runat="server" AutoPostBack="true" OnTextChanged="CtrlChanged" />
            <br /><br />
            <asp:CheckBox ID="chk" runat="server" AutoPostBack="False" OnCheckedChanged="CtrlChanged"/>
            <br /><br />
            <asp:RadioButton ID="opt1" runat="server" GroupName="Sample"
            AutoPostBack="true" OnCheckedChanged="CtrlChanged"/>
            <asp:RadioButton ID="opt2" runat="server" GroupName="Sample" OnCheckedChanged="CtrlChanged" AutoPostBack="True"/>
            <h1>Lista of eventos:</h1>
            <asp:ListBox ID="lstEvents" runat="server" Width="355px"
             Height="150px" /><br />
            <br /><br /><br />
    </div>
    </div>
    </form>
</body>
</html>
