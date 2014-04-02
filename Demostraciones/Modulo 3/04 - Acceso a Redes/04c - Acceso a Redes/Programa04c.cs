using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;

namespace Modulo_3
{
    class Programa04c:Programa
    {
        internal override void Ejecutar()
        {
            #region Realizar un Ping
            // Realizar un ping
            IPAddress ip = IPAddress.Parse("200.107.200.26");
            Ping ping = new Ping();
            //if (NetworkInterface.GetIsNetworkAvailable())
            //{ 
                for (int i = 0; i <= 4; i++)
                {
                    PingReply pr = ping.Send(ip);
                    Console.WriteLine("Respuesta desde {0} bytes={1} Tiempo={2} TTL={3}", pr.Address, pr.Buffer.Length, pr.RoundtripTime, pr.Options.Ttl);
                }
                //}

            #endregion

            #region Comprobar el estado de la red
            
            //Comprobar el estado de la red
            if (NetworkInterface.GetIsNetworkAvailable())
                Console.WriteLine("La Conexión es válida");
            else
                Console.WriteLine("Ninguna interfaz configurada o disponible");

            Console.ReadLine();

            #endregion
        }
    }
}
