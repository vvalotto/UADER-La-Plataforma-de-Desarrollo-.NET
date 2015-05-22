using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IronMan.DTO;
using IronMan.Gestores;

public partial class IronManWeb : System.Web.UI.Page
{
    private EventoGestor _eGestor;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        _eGestor = new EventoGestor();
        LigarComponentes();
    }

    private void LigarComponentes()
    {
        this.listBoxEventos.DataSource = this._eGestor.Listar();
        this.listBoxEventos.DataTextField = "Nombre";
        this.listBoxEventos.DataValueField = "Id";
        this.listBoxEventos.DataBind();
    }

    protected void listBoxEventos_SelectedIndexChanged(object sender, EventArgs e)
    {
        var _eventoIdSeleccionado = Convert.ToInt16(this.listBoxEventos.SelectedValue);

        var _eventoSeleccionado = _eGestor.Obtener(_eventoIdSeleccionado);

        this.txtNombre.Text = _eventoSeleccionado.Nombre;
        this.txtLugar.Text = _eventoSeleccionado.Lugar;
        this.txtFecha.Text = _eventoSeleccionado.Fecha.ToString();
        this.txtComentario.Text = _eventoSeleccionado.Comentario;
    }
}