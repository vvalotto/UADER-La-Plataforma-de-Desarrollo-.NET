using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronMan.LibreriaMVP.Views;
using IronMan.LibreriaMVP.Presenters;
using IronMan.DTO;
using IronMan.Gestores;

namespace IronManWF
{
    public partial class frmListaEventos : Form, IEventosListView
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

        public frmListaEventos()
        {
            _presenter = new EventoListPresenter(this, new EventoGestor());
            InitializeComponent();      
        }
            
        private void frmListaEventos_Load(object sender, EventArgs e)
        {
            _presenter.Inicializar();
            this.dgListaEventos.CellClick += OnEventoDataGridCellSelected;
        }


        public void ListarEventos(IList<EventoDTO> eventos)
        {
            dgListaEventos.DataSource = eventos.ToList();
            dgListaEventos.Columns["Comentario"].Visible = false;
            dgListaEventos.Columns["Pruebas"].Visible = false;
            dgListaEventos.Columns["EstaHabilitado"].Visible = false;
        }

        public void MostrarEvento(EventoDTO evento)
        {
            //MessageBox.Show(evento.Nombre);
        }

        private void OnEventoDataGridCellSelected(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene el id de las fila seleccionada al hacer click
            if (e.RowIndex >= 0)
            {
                _eId = (int)dgListaEventos.Rows[e.RowIndex].Cells["Id"].Value;
                this._presenter.OnEventoSeleccionado();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditEvento _frmEditEvento = new frmEditEvento(_eId);
            _frmEditEvento.MdiParent = this.ParentForm;
            _frmEditEvento.Show();
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditEvento _frmEditEventos = new frmEditEvento(0);
            _frmEditEventos.MdiParent = this.ParentForm;
            _frmEditEventos.Show();
        }
    }
}
