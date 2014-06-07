using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClienteService
    {
        
        //Definición de todas las operaciones que son expuestas por el servicio
        [OperationContract]
        Clientes GetCliente(int IDCliente);

        [OperationContract]
        List<Clientes> GetClientes();

        [OperationContract]
        int InsertarCliente(Clientes Cli);

        [OperationContract]
        Clientes ActualizarCliente(Clientes Cli);

        [OperationContract]
        void EliminarCliente(Clientes Cli);

       
    }

    // Se definen los tipos personalizados que son usados por el servicio y ademas son expuestos para su uso
    // externo
    [DataContract]
    public class BusquedaCliente
    {
        [DataMember]
        public int IDCliente { get; set; }

        [DataMember]
        public int Nombre { get; set; }

    }
}
