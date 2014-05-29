using System;
using System.Collections.Generic;

namespace IronMan.Dominio.Modelos
{
    // Definición de la Entidad de Negocio: Evento
    public partial class Evento
    {
        public Evento()
        {
            this.Pruebas = new List<Prueba>();
            this.Fecha = DateTime.Now;
            this.Comentario = "Sin Comentarios";
            this.EstaHabilitado = true;
        }

        //Identificador
        public int Id { get; set; }

        //Atributos o Propiedades
        public string Nombre { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Comentario { get; set; }
        public bool EstaHabilitado { get; set; }

        //Relaciones con las pruebas del evento
        public virtual ICollection<Prueba> Pruebas { get; set; }

        //Funciones de ayuda
        public override string ToString()
        { 
            String retorno;
            retorno = "Nombre : " + this.Nombre + "\n";
            retorno = retorno + "Lugar :" + this.Lugar;
            return retorno;
        }
    }
}
