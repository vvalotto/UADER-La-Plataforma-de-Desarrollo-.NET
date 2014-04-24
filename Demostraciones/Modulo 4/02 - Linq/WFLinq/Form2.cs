using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLinq
{
    public partial class Form2 : Form
    {
        Proyectos _proyecto = new Proyectos();
        ManejadorProyectos _mProyectos = new ManejadorProyectos();
        ProyectosDataContext _ctx = new ProyectosDataContext();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            var datosProyecto = from p in _ctx.Proyectos
                               select p;


            this.dataGridView1.DataSource = datosProyecto;
            this.dataGridView1.Columns[3].Visible = false;

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow Fila = new DataGridViewRow();
            Fila = dataGridView1.CurrentRow;

            if ((Fila.Index + 1) < dataGridView1.RowCount)
            {
                int i = Convert.ToInt32(Fila.Cells["ID"].Value); 
                _proyecto=_mProyectos.ObtenerProyecto(_ctx, i);
                txtID.Text = _proyecto.ID.ToString();
                txtTitulo.Text = _proyecto.Titulo; ;
                txtIDCliente.Text = _proyecto.IDCliente.ToString();
            }
            else{
                _proyecto = null;
                txtID.Text = string.Empty;
                txtTitulo.Text = string.Empty;
                txtIDCliente.Text = string.Empty;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            if (_proyecto == null)
            {
                _proyecto = new Proyectos();
                _proyecto.ID = Convert.ToInt32(txtID.Text);
                _proyecto.Titulo = txtTitulo.Text;
                _proyecto.IDCliente = Convert.ToInt32(txtIDCliente.Text);
                _mProyectos.GuardarProyecto(_ctx, _proyecto);
                var datosProyecto = from p in _ctx.Proyectos
                                    select p;


                this.dataGridView1.DataSource = datosProyecto;
            }
            else
            {
                _proyecto.ID = Convert.ToInt32(txtID.Text);
                _proyecto.Titulo = txtTitulo.Text;
                _proyecto.IDCliente = Convert.ToInt32(txtIDCliente.Text);
                _mProyectos.ActualizarProyecto(_ctx, _proyecto);
                var datosProyecto = from p in _ctx.Proyectos
                                    select p;


                this.dataGridView1.DataSource = datosProyecto;
 
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (_proyecto == null)
            {
                MessageBox.Show("Nada para eliminar!");
            }
            else
            {
                _proyecto.ID = Convert.ToInt32(txtID.Text);
                _mProyectos.EliminarProyecto(_ctx, _proyecto.ID);

                var datosProyecto = from p in _ctx.Proyectos
                                    select p;
                this.dataGridView1.DataSource = datosProyecto;

            }
        }

      

    }
}
