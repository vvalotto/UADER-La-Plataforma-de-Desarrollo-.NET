using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronManWF
{
    public partial class frmIronMan : Form
    {
        public frmIronMan()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listarEventoMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEventos _frmListaEventos = new frmListaEventos();
            _frmListaEventos.MdiParent = this;
            _frmListaEventos.Show();

        }

        private void nuevoEventoMenuItem_Click(object sender, EventArgs e)
        {
            frmEditEvento _frmEditEventos = new frmEditEvento(0);
            _frmEditEventos.MdiParent = this;
            _frmEditEventos.Show();
        }
    }
}
