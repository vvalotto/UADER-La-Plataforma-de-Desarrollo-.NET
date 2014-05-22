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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace WpfLab053
{
    /// <summary>
    /// Lógica de interacción para BindingADO.xaml
    /// </summary>
    public partial class BindingADO : Window
    {
        ClientesProyectos miDataSet = new ClientesProyectos();
        ClientesProyectosTableAdapters.ClientesTableAdapter cliAdapter = new ClientesProyectosTableAdapters.ClientesTableAdapter();
        ClientesProyectosTableAdapters.ProyectosTableAdapter proAdapter = new ClientesProyectosTableAdapters.ProyectosTableAdapter();
        
        public BindingADO()
        {
            
            InitializeComponent();
            cliAdapter.Fill(miDataSet.Clientes);
            proAdapter.Fill(miDataSet.Proyectos);
            grid1.DataContext = miDataSet.Clientes;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
