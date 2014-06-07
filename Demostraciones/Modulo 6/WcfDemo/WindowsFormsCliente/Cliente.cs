using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsCliente.ServiceReference1;

namespace WindowsFormsCliente
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var svc = new ClienteServiceClient();

            var nuevoCliente = new Clientes
            {
                IDCliente = Convert.ToInt32(textBox1.Text),
                Nombre = textBox2.Text,
                IDContacto = Convert.ToInt32(textBox3.Text),
                Calle = textBox4.Text,
                Numero = textBox5.Text,
                Piso = textBox6.Text,
                Departamento = textBox7.Text,
                Cuidad = textBox8.Text,
                Provincia = textBox9.Text,
                Pais = textBox10.Text,
                Telefono = textBox11.Text,
                Web = textBox12.Text
            };
            var nuevoCliID = svc.InsertarCliente(nuevoCliente);

            MessageBox.Show("Cliente Agregado");
        }
    }
}
