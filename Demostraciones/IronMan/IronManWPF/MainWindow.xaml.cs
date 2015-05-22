using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using IronMan.DTO;
using IronMan.Gestores;

namespace IronManWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly EventoGestor _eGestor;

        public MainWindow()
        {
            
            InitializeComponent();
            this._eGestor = new EventoGestor();
            DataContext = _eGestor.Listar().ToList();
        }

        private void listBoxEventos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //EventoDTO _eventoSeleccionado = (EventoDTO)this.listBoxEventos.SelectedItem;

            //this.txtNombre.Text = _eventoSeleccionado.Nombre;
            //this.txtLugar.Text = _eventoSeleccionado.Lugar;
            //this.txtFecha.Text = _eventoSeleccionado.Fecha.ToString();
            //this.txtComentario.Text = _eventoSeleccionado.Comentario;

           
        }
    }
}
