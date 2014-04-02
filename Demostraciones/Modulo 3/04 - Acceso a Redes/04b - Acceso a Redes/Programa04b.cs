using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Modulo_3
{
    class Programa04b:Programa
    {
        internal override void Ejecutar()
        {
            #region Constantes
            
            //const string ftpstring = "ftp://ftp.rediris.es";
            const string ftpstring = "ftp://ftp.mozilla.org/pub/mozilla.org/";
            //const string usuario = "anonimous@nadie.com";

            #endregion 

            #region Acceso a un ftp y lectura del mismo

            try
            {
                FtpWebRequest ftprequest = (FtpWebRequest)FtpWebRequest.Create(ftpstring);
                NetworkCredential credencial = new NetworkCredential(string.Empty, string.Empty);
                ftprequest.Credentials = credencial;
                ftprequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                StreamReader reader = new StreamReader(ftprequest.GetResponse().GetResponseStream());
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            #endregion

        }
    }
}
