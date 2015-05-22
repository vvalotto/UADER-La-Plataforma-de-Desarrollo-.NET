using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public partial class EjemploDataReader : Form
    {
        public EjemploDataReader()
        {
            InitializeComponent();
        }

        private void EjemploDataReader_Load(object sender, EventArgs e)
        {

            try
            {

                string ConsultaSQL;

                //PASO 1 - Se establece la cadena de conexión con la base de datos (Capa Conectada)
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=VICTOR-HP;Initial Catalog=Proyectos;Integrated Security=True;Pooling=False";

                //PASO 2 - Se define el comando (tipo de acceso) a la base de datos (Capa conectada)
                ConsultaSQL = "select Nombre from Clientes";
                //ConsultaSQL = "Select Clientes.Nombre, Proyectos.Titulo from Clientes, Proyectos Where Clientes.ID = Proyectos.IDCliente";
                SqlCommand miComando = new SqlCommand(ConsultaSQL, conn);


                //Se define el objeto datareader(Capa conectada)
                SqlDataReader miDataReader;

                //PASO 3 - Se abre la conexion
                conn.Open();

                //PASO 4 - Se obtienen los datos
                miDataReader = miComando.ExecuteReader();

                //PASO 5 - Se usan los datos
                textBox.Text = "Se ejecutó el acceso a datos\r\n";
                textBox.Text += "----------------------------\r\n";
                textBox.Text += "Lista de Datos extraidos\r\n";
                while (miDataReader.Read())
                {
                    textBox.Text += miDataReader["nombre"].ToString() + "\r\n";
                    //textBox.Text += miDataReader[0] + " - " + miDataReader[1] + "\r\n";
                }
                //PASO 6 - Se cierra la conexion
                miComando = null;
                conn.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
