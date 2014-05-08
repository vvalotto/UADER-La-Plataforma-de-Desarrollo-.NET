using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAGA.Modelo

{
    public class Destino
    {
        public int DestinoId { get; set; }

        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Descripcion { get; set; }

        public byte[] Foto { get; set; }

        public List<Hospedaje> Hospedajes { get; set; }
    }
}
