using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAGA.Modelo
{
    public class Viaje
    {
        public Guid Identificador { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal CostoUSD { get; set; }
    }
}
