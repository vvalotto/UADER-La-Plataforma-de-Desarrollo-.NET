using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Modulo_4
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

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int IDCliente
        {
            get { return _IDCliente; }
            set { _IDCliente = value; }
        }

    }
}
