using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    #region Constantes

    public const string RequiredFieldValidator = "{0} es un dato requerido.";
    public const string CustomValidatorCuit = "El CUIT ingresado no es válido";
    public const string RegularExpressionCaracteresEspeciales = "{0} contiene caracteres no permitidos. Ejemplo: < > %";
    public const string CorreoElectronicoInvalido = "Correo Electronico inválido.";
    public const string RegularExpressionValidatorFormato = "{0} no cumple con el formato establecido de {1}";

    public const string ddmmaaaa = "dd/mm/aaaa";

    public const string ExpresionRegularParaFecha = @"[0-9]{1,2}/[0-9]{1,2}/[0-9]{4}";

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            AgregarMensajes();
        }
        lblResultado.Visible = false;

    }


    #region Eventos

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        lblResultado.Text = string.Format("Nombre: {0}, Apellido: {1}, Cuit: {2}, Fecha de Nacimiento: {3}, Tipo: {4}", 
                                           tbNombre.Text, 
                                           tbApellido.Text, 
                                           tbCuit.Text, 
                                           tbFechaNacimiento.Text, 
                                           ddlTipo.SelectedItem.Text);

        lblResultado.Visible = true;

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        tbNombre.Text = string.Empty;
        tbApellido.Text = string.Empty;
        tbFechaNacimiento.Text = string.Empty;
        tbCuit.Text = string.Empty;
        ddlTipo.SelectedValue = "0";
    }

    #endregion 

    #region Métodos Privados

    private void AgregarMensajes()
    {
        rfvNombre.ErrorMessage = string.Format(RequiredFieldValidator, "Nombre");
        rfvApellido.ErrorMessage = string.Format(RequiredFieldValidator, "Apellido");
        rfvCuit.ErrorMessage = string.Format(RequiredFieldValidator, "CUIT");
        rfvTipo.ErrorMessage = string.Format(RequiredFieldValidator, "Tipo");

        cvApellido.ErrorMessage = string.Format(RegularExpressionCaracteresEspeciales, "Apellido");
        cvNombre.ErrorMessage = string.Format(RegularExpressionCaracteresEspeciales, "Nombre");
        cvCuitCaracteresInvalidos.ErrorMessage = string.Format(RegularExpressionCaracteresEspeciales, "CUIT");

        cvCuit.ErrorMessage = CustomValidatorCuit;

        revFechaNacimiento.ValidationExpression = ExpresionRegularParaFecha;
        revFechaNacimiento.ErrorMessage = string.Format(RegularExpressionValidatorFormato, "Fecha Vencimiento", ddmmaaaa);
    }

    #endregion
    protected void cvNombre_ServerValidate(object source, ServerValidateEventArgs args)
    {

    }
}