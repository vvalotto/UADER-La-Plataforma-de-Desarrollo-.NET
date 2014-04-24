using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccesoADatos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EjemploDataReader Ejemplo1 = new EjemploDataReader();
            
            Ejemplo1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EjemploDataReader2 Ejemplo2 = new EjemploDataReader2();

            Ejemplo2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EjemploDataAdapter Ejemplo3 = new EjemploDataAdapter();

            Ejemplo3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EjemploDataAdapter2 Ejemplo4 = new EjemploDataAdapter2();

            Ejemplo4.Show();
        }


     }
}
