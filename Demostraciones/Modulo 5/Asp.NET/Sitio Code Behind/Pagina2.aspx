<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina2.aspx.cs" Inherits="Pagina2" %>

<!DOCTYPE html>
<script runat="server">
protected void TimeLabel_Load(object sender, EventArgs e)
    {
    TimeLabel.Text = DateTime.Now.ToString();
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2> Hola </h2>

                La hora es:
                <asp:Label ID="TimeLabel" runat="server" onload="TimeLabel_Load"></asp:Label>
     </div>
    </form>
</body>
</html>
