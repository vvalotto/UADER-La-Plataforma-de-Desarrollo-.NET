using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IronManServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEventoServicio
    {
        [OperationContract]
        string ObtenerNombreEvento(int id);

        [OperationContract]
        void Guardar(Evento e);

        [OperationContract]
        Evento Obtener(int id);

        [OperationContract]
        List<Evento> Listar();

    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Evento
    {
        [DataMember]
        public string Nombre { set; get; }

        [DataMember]
        public string Lugar { set; get; }

        [DataMember]
        public string Comentario { set; get; }

        [DataMember]
        public DateTime Fecha { set; get; }
    }
}
