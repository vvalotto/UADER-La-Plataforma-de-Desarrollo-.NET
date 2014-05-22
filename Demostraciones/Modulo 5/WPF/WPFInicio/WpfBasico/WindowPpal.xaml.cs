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

namespace WpfBasico
{
    /// <summary>
    /// Lógica de interacción para WindowPpal.xaml
    /// </summary>
    public partial class WindowPpal : Window
    {
        public WindowPpal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mWin = new MainWindow();
            mWin.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow2 mWin2 = new MainWindow2();
            mWin2.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow3 mWin3 = new MainWindow3();
            mWin3.Show();
        }
    }
}
