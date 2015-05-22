using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronMan.Gestores;

namespace IronManMVCBasico
{
    public partial class Form1 : Form
    {
        EventoGestor _eGestor = new EventoGestor();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBoxEventos.DisplayMember = "Nombre";
            this.listBoxEventos.ValueMember = "Id";
            this.listBoxEventos.DataSource = this._eGestor.Listar();
        }
    }
}
