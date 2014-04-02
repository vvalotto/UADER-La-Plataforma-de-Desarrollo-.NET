using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modulo_2
{
    class Programa15:Programa
    {            
        
        //Ejemplo básico de uso de genericoa
        public class ManejadorEntidad<T>
        {
            #region Declaracion de los miembros de tipos
            private T _entidad;
            public T Entidad
            {
                 set {_entidad = value;}
                 get {return _entidad;}
            }
            #endregion

            #region Declaracion de los miembros metodos
            public void Guardar()
            {
                TextWriter _fEntidad = File.AppendText(@"C:\Temp\Genericos.Txt");
                try
                {
                    _fEntidad.WriteLine(_entidad);

                }
                catch (IOException)
                {
                    Console.WriteLine("Error el escribir en el archivo");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.TargetSite + ex.Source);
                }
                finally
                {
                    _fEntidad.Close();
                }
            }
            #endregion


        }
        internal override void Ejecutar()
        {
            
            ManejadorEntidad<int> mInt = new ManejadorEntidad<int>();
            ManejadorEntidad<bool> mBool = new ManejadorEntidad<bool>();
            ManejadorEntidad<string> mString = new ManejadorEntidad<string>();
            ManejadorEntidad<Persona> mPersona = new ManejadorEntidad<Persona>();

            int _i = 120;
            bool _b = true;
            string _s = "alguna palabra";
            Persona _miHijo = new Persona("Alejo", "Valotto", 5, Genero.Masculino);

            mInt.Entidad = _i;
            mBool.Entidad = _b;
            mString.Entidad = _s;
            mPersona.Entidad = _miHijo;

            Console.WriteLine("Entero: {0}", mInt.Entidad);
            Console.WriteLine("Boolean: {0}", mBool.Entidad);
            Console.WriteLine("Cadena: {0}", mString.Entidad);
            Console.WriteLine("Persona: {0}", mPersona.Entidad);

            mInt.Guardar();
            mBool.Guardar();
            mString.Guardar();
            mPersona.Guardar();

            Console.ReadKey();
        }
       
    }
}
