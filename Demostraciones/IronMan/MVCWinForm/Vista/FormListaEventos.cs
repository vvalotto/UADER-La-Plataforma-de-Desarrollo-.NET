using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCWinForm.Controlador;
using MVCWinForm.Modelo;
using IronMan.DTO;

namespace MVCWinForm.Vista
{
    public partial class FormListaEventos : Form, IVistaListarEvento, IVistaObservador
    {
        private List<IControladorObservador> controladores = new List<IControladorObservador>();

        public FormListaEventos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ComandoListarEventos()
        {
        }

        public void EjecutarMostarEvento(int id)
        {
            
        }

        public void ListarEventos(IList<EventoDTO> eventos)
        {
            listBoxEventos.DataSource = eventos;
        }

        public void MostrarEventos(EventoDTO evento)
        {
            throw new NotImplementedException();
        }

        public void EjecutarListarEventos()
        {
            Notificar("listar");
        }

        public void AdjuntarControlador(IControladorObservador controlador)
        {
            controladores.Add(controlador);
        }

        public void RemoverControlador(IControladorObservador controlador)
        {
            controladores.Remove(controlador);
        }

        public void Notificar(string accion)
        {
            controladores.ForEach(x => x.Ejecutar(accion));
        }

        private void FormListaEventos_Load(object sender, EventArgs e)
        {
            EjecutarListarEventos();
        }

        public void Actualizar(string tipoArctualizacion)
        {
            lblAccion.Text = tipoArctualizacion;
        }
    }
}
