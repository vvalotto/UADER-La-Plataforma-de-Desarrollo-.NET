using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Campeonato.Datos;

namespace Campeonato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new ModeloCampeonatoContainer())
            {
                Equipo equipo = new Equipo { Id = 1, Nombre = textBox1.Text };
                TablaPosiciones tposiciones = new TablaPosiciones
                {
                    PE = 0,
                    PG = 0,
                    PP = 0
                };

                ctx.Equipos.Add(equipo);
                ctx.TablasPosiciones.Add(tposiciones);
                ctx.SaveChanges();
                MessageBox.Show("Insertado");
                textBox1.Text = "";
            }
        }
    }
}
