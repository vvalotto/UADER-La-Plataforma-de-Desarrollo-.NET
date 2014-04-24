using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace AccesoADatos
{
    public partial class EjemploDataAdapter : Form
    {
        public EjemploDataAdapter()
        {
            InitializeComponent();
        }

        private void EjemploDataAdapter_Load(object sender, EventArgs e)
        {
            //Se establece la cadena de conexión con la base de datos
            //SqlConnection conn = new SqlConnection();
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source=VICTOR-HP\SQLEXPRESS;Initial Catalog=Proyectos;Integrated Security=True;Pooling=False";
                //Se define el tipo de acceso a la base de datos 
                string strSQL = "select nombre, web from clientes";
                //Se define el objeto DataAdapter (Capa descconectada) y ejecuta el commando accediendo a la base de datos
                SqlDataAdapter miDataAdapter = new SqlDataAdapter(strSQL, conn);

                //Se define el componente que contendra los datos para su manipulacion (Capa Desconectada)
                DataSet miDataSet = new DataSet();
                //Se llena el componente con los datos.
                miDataAdapter.Fill(miDataSet, "Clientes");

                //Se muestran los datos obtenidos
                foreach (DataRow Fila in miDataSet.Tables[0].Rows)
                {
                    textBox1.Text += Fila["nombre"].ToString() + "\t" + Fila["web"].ToString() + "\r\n";
                }
                miDataSet = null;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
