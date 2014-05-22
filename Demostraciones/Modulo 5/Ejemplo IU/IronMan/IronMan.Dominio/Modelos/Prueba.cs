using System;
using System.Collections.Generic;

namespace IronMan.Dominio.Modelos
{
    //Definición de la Entidad de Negocio: Prueba
    public partial class Prueba
    {
        public Prueba()
        {
            this.Participantes = new List<Participante>();
        }

       //Identificador
        public int Id { get; set; }

        //Atributos o propiedades
        public string Tipo { get; set; }
        public string Distancia { get; set; }
        public int Evento_Id { get; set; }
        public bool EstaHabilitado { get; set; }

        //Relación con el evento al que pertence
        public virtual Evento Evento { get; set; }

        //Relaciones con los participantes de la prueba
        public virtual ICollection<Participante> Participantes { get; set; }
    }
}
