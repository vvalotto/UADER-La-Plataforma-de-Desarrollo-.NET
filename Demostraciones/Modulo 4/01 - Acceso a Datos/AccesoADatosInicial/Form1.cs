using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoADatosInicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void proyectosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proyectosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyectosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectosDataSet.Proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.proyectosDataSet.Proyectos);
            // TODO: esta línea de código carga datos en la tabla 'proyectosDataSet.Proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.proyectosDataSet.Proyectos);

        }

        private void proyectosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.proyectosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyectosDataSet);

        }
    }
}
