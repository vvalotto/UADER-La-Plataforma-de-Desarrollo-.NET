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

namespace APSoftWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            WPFGrid miGrid = new WPFGrid();
            miGrid.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            WPFStackPanel miStackPanel = new WPFStackPanel();
            miStackPanel.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            WPFDockPanel miDockPanel = new WPFDockPanel();
            miDockPanel.Show();
        }


        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            WPFWrapPanel miWrapPanel = new WPFWrapPanel();
            miWrapPanel.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            WPFCanvas miCanvas = new WPFCanvas();
            miCanvas.Show();
        }
    }
}
