using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             ProyectosDataContext _ctx = new ProyectosDataContext();

            var datosCliente = from tProyecto in _ctx.Proyectos
                               from tClientes in _ctx.Clientes
                               where tClientes.Id == tProyecto.IDCliente
                               group tClientes by tClientes.Nombre into Cli
                               select new
                                {
                                    nombre = Cli.Key,
                                    Cantidad = Cli.Count()
                                };

            this.dataGridView1.DataSource = datosCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Proy = new Proyectos
            {
                IDCliente = 1,
                Titulo = "Proyecto Z",
                ID = 44
            };

            var miContexto = new ProyectosDataContext();
            miContexto.Proyectos.InsertOnSubmit(Proy);
            miContexto.SubmitChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Form1_Load(this, e);
        }
    }
}
