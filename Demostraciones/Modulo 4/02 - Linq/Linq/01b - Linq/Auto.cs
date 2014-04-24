using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_4
{
    internal class Auto
    {
        public string VIN { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return VIN + ";" + Marca + ";" + Modelo + ";" + Anio + ";" + Color;
        }

    }

    internal class Autos
    {
        List<Auto> ObtenerAutos()
        {
            return new List<Auto>
                {
                new Auto {VIN = "ABC123",Marca = "Ford",
                    Modelo = "F-250", Anio = 2000},
                new Auto {VIN = "DEF123",Marca = "BMW",
                    Modelo = "Z-3", Anio = 2005},
                new Auto {VIN = "ABC456",Marca = "Audi",
                    Modelo = "TT", Anio = 2008},
                new Auto {VIN = "HIJ123",Marca = "VW",
                    Modelo = "Bug", Anio = 1956},
                new Auto {VIN = "DEF456",Marca = "Ford",
                    Modelo = "F-150", Anio = 1998}
                };
        }

        internal void MostrarLista()
        {   
            foreach (Auto a in ObtenerAutos())
            {
                Console.WriteLine(a);
            }
        }
    }

    
}
