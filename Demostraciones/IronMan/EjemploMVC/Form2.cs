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
    public partial class Form2 : Form, IVista,  IModeloObservador
    {
        IControlador controlador; 
        public event VistaHandler<IVista> cambiada;

        public void SetControlador(IControlador cont)
        {
            controlador = cont;
        }

        public Form2()
        {
            InitializeComponent();
        }

        public void ValorIncrementado(IModelo modelo, ModeloEventArgs e)
        {
            label1.Text = "" + e.valorNuevo;
        }



    }
}
