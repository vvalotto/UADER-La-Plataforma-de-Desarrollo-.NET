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
using IronMan.Gestores;
using IronMan.DTO;
using IronMan.LibreriaMVP.Presenters;

namespace IronManWF
{
    public partial class frmEditEvento : Form, IEventoEditView
    {
        #region miembros tipos privados
        private readonly EventoEditPresenter _presenter;
        #endregion

        #region Constructor
        public frmEditEvento(int eID)
        {   
            _presenter = new EventoEditPresenter(this, new EventoGestor());
            _presenter._eId = eID;
            InitializeComponent();   
        }
        #endregion

        #region Declaracion de Eventos que maneja el Presenter
        public event Action Guardar;

        public event Action Cancelar;

        public event Action Volver;
        #endregion

        #region Miembros metodos públicos
        public void MostrarEvento(int _eId)
        {
            EventoDTO _eDTOAnterior = _presenter.EventoAnterior;
            this.txtNombre.Text = _eDTOAnterior.Nombre;
            this.txtLugar.Text = _eDTOAnterior.Lugar;
            this.txtComentario.Text = _eDTOAnterior.Comentario;
            this.dtPickFecha.Text = _eDTOAnterior.Fecha.ToString();
        }
        #endregion

        private void frmEditEvento_Load(object sender, EventArgs e)
        {
            _presenter.Inicializar();
            this.btnCancelar.Click += OnClickCancelar;
            this.btnGuardar.Click += OnClickGuardar;
        }

        private void OnClickCancelar(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        private void OnClickGuardar(object sender, EventArgs e)
        {
            this.LlenarEventoDTO();
            try
            {
                this.Guardar();
                MessageBox.Show("Exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema");
            }
            frmListaEventos _frmListaEventos = new frmListaEventos();
            _frmListaEventos.MdiParent = this.ParentForm;
            _frmListaEventos.Show();
            this.Close();
        }
        
        private void LlenarEventoDTO()
        {
            EventoDTO _eDTONuevo = new EventoDTO();
            _eDTONuevo.Id = _presenter._eId;
            _eDTONuevo.Nombre = this.txtNombre.Text;
            _eDTONuevo.Lugar = this.txtLugar.Text;
            _eDTONuevo.Comentario = this.txtComentario.Text;
            _eDTONuevo.Fecha = Convert.ToDateTime(this.dtPickFecha.Text);
            _presenter.EventoNuevo = _eDTONuevo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmListaEventos _frmListaEventos = new frmListaEventos();
            _frmListaEventos.MdiParent = this.ParentForm;
            _frmListaEventos.Show();
            this.Close();
        }
    }
}
