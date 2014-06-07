using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfCalculo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICalculadoraServicio
    {
        [OperationContract]
        Resultado Sumar(decimal operador1, decimal operador2);

        [OperationContract]
        Resultado Restar(decimal operador1, decimal operador2);

        [OperationContract]
        Resultado Multiplicar(decimal operador1, decimal operador2);

        [OperationContract]
        Resultado Dividir(decimal numerador, decimal denominador);

    }

    [DataContract]
    public class Resultado
    {
        [DataMember]
        public decimal Valor { get; set; }

        [DataMember]
        public string Mensaje { get; set; }

        [DataMember]
        public bool Error { get; set; }
    }
}
