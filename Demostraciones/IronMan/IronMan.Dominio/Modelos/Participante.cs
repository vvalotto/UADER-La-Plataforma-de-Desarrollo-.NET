using System;
using System.Collections.Generic;

namespace IronMan.Dominio.Modelos
{
    //Definición de la Entidad de Negocio: Participante
    public partial class Participante
    {
        //Identificador
        public int Id { get; set; }

        //Atributos o Propiedades
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public string Domicilio_Calle { get; set; }
        public short Domicilio_Numero { get; set; }
        public string Domicilio_Piso { get; set; }
        public short Domicilio_Departamento { get; set; }
        public string Domicilio_Cuidad { get; set; }
        public string Domicilio_Provincia { get; set; }
        public string Domicilio_Pais { get; set; }
        public int Prueba_Id { get; set; }
        public bool  EstaHabilitado { get; set; }

        //Relación con la prueba donde participa
        public virtual Prueba Prueba { get; set; }
    }
}
