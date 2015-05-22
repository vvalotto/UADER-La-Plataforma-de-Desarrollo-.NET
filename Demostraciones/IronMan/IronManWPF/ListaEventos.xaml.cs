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
using System.Windows.Shapes;
using IronMan.Gestores;
using IronMan.DTO;
using IronMan.Dominio;

namespace IronManWPF
{
    /// <summary>
    /// Lógica de interacción para ListaEventos.xaml
    /// </summary>
    public partial class ListaEventos : Window
    {
        public ListaEventos()
        {
            InitializeComponent();
            var _eGestor = new EventoGestor();
            this.DataContext = _eGestor.Listar().ToList();
        }
    }
}
