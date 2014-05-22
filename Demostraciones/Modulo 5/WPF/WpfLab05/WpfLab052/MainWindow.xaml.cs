using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLab053
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Fase> Fases = new List<Fase>();

            Fase f1 = new Fase();
            f1.Codigo = "01";
            f1.Nombre = "Requerimientos";
            Fases.Add(f1);

            Fase f2 = new Fase();
            f2.Codigo = "02";
            f2.Nombre = "Diseño";
            Fases.Add(f2);

            grid1.DataContext = Fases;

            System.ComponentModel.ICollectionView miVista;
            miVista = CollectionViewSource.GetDefaultView(Fases);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
