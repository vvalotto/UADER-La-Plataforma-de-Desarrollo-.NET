using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IronMan.LibreriaMVP.Views;
using IronMan.LibreriaMVP.Presenters;
using IronMan.DTO;
using IronMan.Gestores;

public partial class ListaEventos : System.Web.UI.Page, IEventosListView
{
    private readonly EventoListPresenter _presenter;
    private int _eId;

    public event Action SeleccionarEvento;

    public event Action Cerrar;

    public IList<EventoDTO> Eventos
    {
        get { return this.dgListaEventos.DataSource as IList<EventoDTO>; }
    }

    public int EventoSeleccionado
    {
        get { return _eId; }
    }

    public ListaEventos()
    {
        _presenter = new EventoListPresenter(this, new EventoGestor());        
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Page_Init (object sender, EventArgs e)
    {
        _presenter.Inicializar();
        this.dgListaEventos.RowEditing += OnEventoDataGridCellSelected;
    }
    
    protected void dgListaEventos_RowCreated(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Center;
        e.Row.Cells[4].Visible = false;
        e.Row.Cells[5].Visible = false;
    }
    
    public void ListarEventos(IList<EventoDTO> eventos)
    {
        this.dgListaEventos.DataSource = eventos.ToList();
        dgListaEventos.DataBind();
    }

    public void MostrarEvento(EventoDTO evento)
    {     
    }

    private void OnEventoDataGridCellSelected(object sender, GridViewEditEventArgs e)
    {
        //Obtiene el id de las fila seleccionada al hacer click
        if (e.NewEditIndex >= 0)
        {
            string url = "~/Evento.aspx?eID=";
            _eId = Convert.ToInt32(dgListaEventos.Rows[e.NewEditIndex].Cells[1].Text);
            this._presenter.OnEventoSeleccionado();
            url = url + _eId.ToString();
            HttpContext.Current.Response.Redirect(url);
        }
    }

}