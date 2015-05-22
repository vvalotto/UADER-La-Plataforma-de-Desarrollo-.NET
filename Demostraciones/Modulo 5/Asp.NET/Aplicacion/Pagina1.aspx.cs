using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Utils util = new Utils();
        lbVersion.Text = util.NombreMaquina();
    }

    protected void btnServerTransfer_Click(object sender, EventArgs e)
    {
        Server.Transfer("~/Menu.aspx");
    }
}