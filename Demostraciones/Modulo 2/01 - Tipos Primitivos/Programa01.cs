using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa01:Programa
    {
        internal override void Ejecutar()
        {
            //Definiciones de Tipo de datos primitivos

            //Tipo de Datos numericos
            //a. Numerico entero
            int numeroEntero; //tamaño = 32
            System.Int32 numeroEntero2; //Definición en la Plataforma .NET

            short numeroCorto;  //tamaño = 16
            long numeroLargo; //tamaño = 64

            //b. Numerico sin signo
            uint numeroEnteroSinSigno; //tamaño = 32
            ushort numeroCortoSinSigno; //tamaño = 16
            ulong numeroLargoSinSigno; //tamaño = 32

            //c. Numerico racional
            float numeroComaFlotantePresicion1; //tamaño = 16
            double numeroComaFlotantePrecision2; //tamaño = 32
            decimal numeroDecimal; // Tamaño = 128  

            //1. Definiciones en la plataform .NET
            System.Int16 i16 = new short();
            System.Int32 i32 = new int();
            System.Int64 i64 = new long();
            Console.WriteLine("\n1>");
            Console.WriteLine("Tipos de datos numericos");
            Console.WriteLine("i16:{0}, i32:{1}, i64:{2}", i16, i32, i64);
            Console.ReadKey();
            /*Environment.Exit(0);*/

            //2.Conversion implicita
            i16 = 100;
            i32 = i16;
            i64 = i32;
            Console.WriteLine("\n2>");
            Console.WriteLine("Conversión Explícita");
            Console.WriteLine("i16:{0}, i32:{1}, i64:{2}", i16, i32, i64);
            Console.ReadKey();
            /*Environment.Exit(0);*/

            //3. Conversion explicita
            i64 = 150000;
            i32 = (int)i64;
            i16 = (short)i64;
            Console.WriteLine("\n3>");
            Console.WriteLine("i16:{0}, i32:{1}, i64:{2}", i16, i32, i64);
            Console.ReadKey();
            /*Environment.Exit(0);*/

            System.Single f = new float();
            System.Double d = new double();

            f = (float)12.45;
            d = f;

            d = 1348897897945.56;
            i16 = (Int16)d;
            Console.WriteLine("f:{0}  d:{1}  i16{2}", f, d, i16);

            //4. Bytes
            byte nByte; //tamaño = 8
            sbyte nByteConSigno; //tamaño = 8
            nByte = 200;
            nByteConSigno = (sbyte)nByte;
            Console.WriteLine("\n4>");
            Console.WriteLine("Tipo Bytes");
            Console.WriteLine("nByte: " + nByte.ToString());
            Console.WriteLine("nByteConSigno: " + nByteConSigno.ToString());
            Console.ReadKey();
            /*Environment.Exit(0);*/

            //5. Caracteres
            char caracter;// tamaño = 16
            string cadenaTexto;

            caracter = '1';
            cadenaTexto = "a" + "b";
            cadenaTexto = cadenaTexto + caracter;
            cadenaTexto += cadenaTexto;
            Console.WriteLine("\n5>");
            Console.WriteLine("Cadenas");
            Console.WriteLine("cadenaTexto: " + cadenaTexto);
            Console.ReadKey();
            /*Environment.Exit(0);*/

            //6. Booleano
            bool tipoBooleano; //tamaño = 8
            tipoBooleano = false;
            Console.WriteLine("\n6>");
            Console.WriteLine("Tipo Booleano");
            Console.WriteLine("tipoBooleano: " + tipoBooleano.ToString());
            Console.ReadKey();
            /*Environment.Exit(0);*/
  

            //7.Conversiones de tipos primitivos
            numeroCorto = 12;
            numeroEntero = numeroCorto;
            numeroEnteroSinSigno = (uint)numeroCorto;
            numeroComaFlotantePrecision2 = numeroCorto;

            numeroLargo = 12L;

            //8. Funciones de Conversion
            cadenaTexto = Convert.ToString (i64);

            caracter = '3';
            nByte = Convert.ToByte(caracter);
            tipoBooleano = Convert.ToBoolean(i64);
            Console.WriteLine("\n8>");
            Console.WriteLine("Funciones de Conversión");
            Console.WriteLine("Es numero: " + i64);
            Console.WriteLine("Es texto: " + cadenaTexto);
            Console.WriteLine(cadenaTexto.GetHashCode());
            Console.WriteLine("Es booleano: " + tipoBooleano);
            Console.ReadKey();

            //9. Tipo Base ValueType
            char c = new char();
            c = 'a';
            int i = 30;

            System.ValueType vt;
            vt = c;
            Console.WriteLine("\n9>");
            Console.WriteLine("Tipo Base ValueType");
            Console.WriteLine(vt.GetType());
       
            Console.ReadKey();

        }

    }
}
