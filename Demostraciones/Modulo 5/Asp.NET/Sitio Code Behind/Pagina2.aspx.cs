using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TimeLabel.Text = DateTime.Now.ToString();
    }

    protected void Button_OnClick(object sender, EventArgs e)
    {
        TimeLabel.Text = "Hubo un evento!!!";
    }
}