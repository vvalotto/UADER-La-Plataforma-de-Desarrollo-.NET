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
    public partial class EjemploDataReader2 : Form
    {
        public EjemploDataReader2()
        {
            InitializeComponent();
        }

        private void EjemploDataReader2_Load(object sender, EventArgs e)
        {
            //1. Se establece la cadena de conexión con la base de datos (Capa Conectada)
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=VICTOR-HP\SQLEXPRESS;Initial Catalog=Proyectos;Integrated Security=True;Pooling=False";

            //2. Se define el comando (tipo de acceso) a la base de datos (Capa conectada)
            SqlCommand miComando = new SqlCommand("select nombre,calle, numero, piso, departamento from clientes", conn);

            //Se define el objeto datareader(Capa conectada)
            SqlDataReader miDataReader;
            //Se Define los datos de un objeto desconectado
            DataTable miTabla = new DataTable();

            //Se abre la conexion
            conn.Open();
            //Se obtienen los datos
            miDataReader = miComando.ExecuteReader();
            //Se usan los datos, se cargan los datos a la tabla desconectada
            miTabla.Load(miDataReader, LoadOption.OverwriteChanges);
            //Se pasan los datos a un componente pata visualizarlos
            dataGridView1.DataSource = miTabla;
            
            //Se cierra la conexion
            miComando = null;
            conn.Close();

        }

    }
}
