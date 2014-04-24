using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AccesoADatos
{
    public class Proyecto
    {
        int _IDProyecto;
        string _nombre;
        string _descripcion;
        int _IDCliente;
        
        public int IDProyecto
        {
            get { return _IDProyecto; }
            set { _IDProyecto = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre= value; }
        }


        public int IDCliente
        {
            get { return _IDCliente; }
            set { _IDCliente = value; }
        }

        public Boolean Insertar(object fila, SqlConnection conn, SqlDataAdapter dataAdapter, DataSet dataSet)
        {
            try
            {
                Proyecto filaProyecto = (Proyecto)fila;

                //Crea la cadena para el acción a la base de datos - Insertar
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO PROYECTOS(IDProyecto, Nombre, Descripcion, IDCliente) VALUES(@IDProyecto, @Nombre, @Descripcion, @IDCliente)";
                command.Connection = conn;
                
                //Asigna la acción al dataAdpater
                dataAdapter.InsertCommand = command;
                command.Parameters.AddWithValue("@IDProyecto", filaProyecto.IDProyecto);
                command.Parameters.AddWithValue("@Nombre", filaProyecto.Nombre);
                command.Parameters.AddWithValue("@IDCliente", filaProyecto.IDCliente);

                //Se conecta a la base de datos y realiza de acción desde el dataAdapter
                conn.Open();
                dataAdapter.Update(dataSet, "Proyectos");
                conn.Close();

                MessageBox.Show("Insertar");
                return true;
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message);
                return false;
            }


            
        }
    }
}
