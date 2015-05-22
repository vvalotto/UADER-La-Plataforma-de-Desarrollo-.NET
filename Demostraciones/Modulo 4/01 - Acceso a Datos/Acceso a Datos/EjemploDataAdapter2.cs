using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AccesoADatos
{
    public partial class EjemploDataAdapter2 : Form
    {
        
        
        public EjemploDataAdapter2()
        {
            InitializeComponent();
        }

        
        private void EjemploDataAdapter2_Load(object sender, EventArgs e)
        {
            
            try
            {
   
                //Establecemos la cadena SQL a utilizar
                //Para esta caso se usa el Objeto SelectCommnand para obtener datos
                SqlCommand command = new SqlCommand("select * from Proyectos",sqlConnection1);
                sqlDataAdapter1.SelectCommand = command;
                
                //Poblamos el dataSet con los resultados obtenidos de la instruccion SQL
                sqlDataAdapter1.Fill(dataSet1,"Proyectos");
                
                //Asignamos el dataset con los datos recuperdos a un componente visual                
                dataGridView1.DataSource = dataSet1.Tables["Proyectos"];
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proyecto unProyecto = new Proyecto();

            //Si los campos tienen datos se agrega el registrio
            if ((textBox1.Text.Length == 0) || (textBox3.Text.Length == 0) || (textBox4.Text.Length == 0))
            {
                MessageBox.Show("Faltan Datos");
            }
            else
            {
                //Se crea la fila en el dataset con los ingresos realizados
                DataRow unaFila = dataSet1.Tables["Proyectos"].NewRow();
                unaFila["ID"] = textBox4.Text;
                unaFila["Titulo"] = textBox1.Text;
                unaFila["IDCliente"] = textBox3.Text;

                dataSet1.Tables["Proyectos"].Rows.Add(unaFila);

                //Se verifica si el data set tuvo cambios
                if (dataSet1.HasChanges())
                {
                    //Como cambio el dataset se realiza la inserción en la tabla
                    //Prepara el objeto Proyecto con los campos a insertat
                    unProyecto.IDProyecto = Convert.ToInt32(textBox4.Text);
                    unProyecto.Nombre = textBox1.Text;
                    unProyecto.IDCliente = Convert.ToInt32(textBox3.Text);

                    //Inserta la fila y verifica el éxito de la acción
                    if (unProyecto.Insertar(unProyecto, sqlConnection1, sqlDataAdapter1, dataSet1))
                    {
                        MessageBox.Show("Insercion exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Inserción Fallida");
                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
