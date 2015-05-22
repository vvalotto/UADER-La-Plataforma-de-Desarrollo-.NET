using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IronMan.LibreriaMVP.Views;
using IronMan.Gestores;
using IronMan.DTO;
using IronMan.LibreriaMVP.Presenters;

public partial class Evento : System.Web.UI.Page, IEventoEditView
{
    private EventoEditPresenter _presenter;

    public Evento()
    {
        _presenter = new EventoEditPresenter(this, new EventoGestor());        
    }

    public void Page_Init()
    {
        _presenter = new EventoEditPresenter(this, new EventoGestor());
        _presenter._eId = Convert.ToInt32(Request.QueryString["eID"]);
        _presenter.Inicializar();
        this.btnCancelar.Click += OnClickCancelar;
        this.btnGuardar.Click += OnClickGuardar;    
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    public event Action Guardar;

    public event Action Cancelar;

    public event Action Volver;

    public void MostrarEvento(int _eId)
    {
        EventoDTO _eDTOAnterior = _presenter.EventoAnterior;
        this.txtNombre.Text = _eDTOAnterior.Nombre;
        this.txtLugar.Text = _eDTOAnterior.Lugar;
        this.txtComentario.Text = _eDTOAnterior.Comentario;
        //this.txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        this.txtFecha.Text = _eDTOAnterior.Fecha.ToString("yyyy-MM-dd");
    }

    private void OnClickCancelar(object sender, EventArgs e)
    {
        this.Cancelar();
    }

    private void OnClickGuardar(object sender, EventArgs e)
    {
        this.LlenarEventoDTO();
        this.Guardar();
        Response.Redirect("~/default.aspx");
    }

    private void LlenarEventoDTO()
    {
        EventoDTO _eDTONuevo = new EventoDTO();
        _eDTONuevo.Id = _presenter._eId;
        _eDTONuevo.Nombre = this.txtNombre.Text;
        _eDTONuevo.Lugar = this.txtLugar.Text;
        _eDTONuevo.Comentario = this.txtComentario.Text;
        _eDTONuevo.Fecha = Convert.ToDateTime(this.txtFecha.Text);
        _presenter.EventoNuevo = _eDTONuevo;
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        this.OnClickGuardar(sender, e);
    }
}