using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BAGA.Modelo
{
    public class Hospedaje
    {
        public int HospedajeId { get; set; }

        public string Nombre { get; set; }
        [Required]
        [MaxLength(200)]

        public string Propietario { get; set; }
        public bool EsResort { get; set; }

        public Destino Destino { get; set; }
    }
}
