using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfLab053
{
    public class Fase
    {
        string _codigo;
        string _nombre;

        public string Codigo
        {
            get
            {
                return _codigo;

            }
            set
            {
                _codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;

            }
            set
            {
                _nombre = value;
            }
        }
    }
}
