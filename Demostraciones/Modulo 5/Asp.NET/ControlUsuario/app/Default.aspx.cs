using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        lblResultado.Visible = false;
    }

    #region Eventos

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        lblResultado.Text = string.Format("Nombre: {0}, Apellido: {1}, Cuit: {2}, Fecha de Nacimiento: {3}, Tipo: {4}", 
                                           ucFormulario.Nombre,
                                           ucFormulario.Apellido,
                                           ucFormulario.Cuit,
                                           ucFormulario.FechaNacimiento,
                                           ucFormulario.Tipo);

        lblResultado.Visible = true; 

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ucFormulario.Nombre = string.Empty;
        ucFormulario.Apellido = string.Empty;
        ucFormulario.FechaNacimiento = string.Empty;
        ucFormulario.Cuit = string.Empty;
        ucFormulario.Tipo = "0"; 
    }

    #endregion 

   
}