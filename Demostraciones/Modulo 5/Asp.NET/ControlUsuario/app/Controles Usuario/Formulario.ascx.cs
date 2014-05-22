using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class app_Controles_Usuario_Formulario : System.Web.UI.UserControl
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

    #region Propiedades

    public string Nombre
    { 
        get { return tbNombre.Text; }
        set { tbNombre.Text = value; }
    }

    public string Apellido
    {
        get { return tbApellido.Text; }
        set { tbApellido.Text = value; }
    }

    public string Cuit
    {
        get { return tbCuit.Text; }
        set { tbCuit.Text = value; }
    }

    public string FechaNacimiento
    {
        get { return tbFechaNacimiento.Text; }
        set { tbFechaNacimiento.Text = value; }
    }

    public string Tipo
    {
        get { return ddlTipo.SelectedItem.Text; }
        set { ddlTipo.SelectedValue = value; }
    }

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            AgregarMensajes();
        }

    }

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
}