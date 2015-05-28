using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMVC
{
    public partial class Form1 : Form, IVista, IModeloObservador
    {
        IControlador controlador;
        public event VistaHandler<IVista> cambiada;

        public void SetControlador(IControlador cont)
        {
            controlador = cont;
        }

        public void ValorIncrementado(IModelo modelo, ModeloEventArgs e)
        {
            textBox1.Text = "" + e.valorNuevo;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador.IncrementarValor();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                cambiada.Invoke(this, new VistaEventArgs(int.Parse(textBox1.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ser un numero valido");
            }
        }





    }
}
