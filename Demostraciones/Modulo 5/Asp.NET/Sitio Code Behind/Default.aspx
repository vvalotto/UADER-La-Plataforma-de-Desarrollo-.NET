<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR
/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
    protected void TimeLabel_Load(object sender, EventArgs e)
    {
    TimeLabel.Text = DateTime.Now.ToString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Single-File Web Form</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        La hora es:
        <asp:Label ID="TimeLabel" runat="server" onload="TimeLabel_Load"></asp:Label>
    </div>
    </form>
    <form>
        <a href="Pagina2.aspx"> Otra Pagina</a>
    </form>
</body>
</html>
