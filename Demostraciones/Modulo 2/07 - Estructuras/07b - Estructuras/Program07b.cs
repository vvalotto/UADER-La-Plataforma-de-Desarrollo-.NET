using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_2
{

    class Programa07b:Programa
    {

        internal override void Ejecutar()
        {
            Persona p = new Persona("Alejo", "Valotto", 5, Genero.Masculino);
            //Persona p = new Persona("Franco", "Valotto", 15);
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }

    internal enum Genero{
        Masculino,
        Femenino
    };

    internal struct Persona
    {
        internal string nombre;
        internal string apellido;
        internal int edad;
        internal Genero genero;

        //internal Persona(string _nombre, string _apellido, int _edad)
        //{
        //    nombre = _nombre;
        //    apellido = _apellido;
        //    edad = _edad;
        //}

        internal Persona(string _nombre, string _apellido, int _edad, Genero _genero)
        {
            nombre = _nombre;
            apellido = _apellido;
            edad = _edad;
            genero = _genero;
        }

        public override string ToString()
        {
            return nombre + " " + apellido + ", edad: " + edad;
        }

        //internal override string ToString()
        //{
        //    return nombre + " " + apellido + ", edad: " + edad;
        //}
    }
}
