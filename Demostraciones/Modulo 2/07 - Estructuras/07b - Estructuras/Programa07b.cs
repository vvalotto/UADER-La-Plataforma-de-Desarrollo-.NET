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
            //Persona p = new Persona("Alejo", "Valotto", 5, Genero.Masculino);
            Persona p = new Persona("Franco", "Valotto", 15);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }

    // Definicion de un tipo Enumerado
    //internal enum Genero{
    //    Masculino,
    //    Femenino
    //};

    // Definicion de un tipo estructura (Persona)
    internal struct Persona
    {
        //Definción de los campos de la estructura persona
        internal string nombre;
        internal string apellido;
        internal int edad;
        //internal Genero genero;

        //Contructor de la Estructura
        //Caso Inicial
        internal Persona(string _nombre, string _apellido, int _edad)
        {
            nombre = _nombre;
            apellido = _apellido;
            edad = _edad;
        }

        //Caso seguiente
        //internal Persona(string _nombre, string _apellido, int _edad, Genero _genero)
        //{
        //    nombre = _nombre;
        //    apellido = _apellido;
        //    edad = _edad;
        //    genero = _genero;
        //}

        //Sobrecarga del Metodo ToString
        //public override string ToString()
        //{
        //    return nombre + " " + apellido + "(" + genero + "), edad: " + edad;
        //}

        public override string ToString()
        {
            return nombre + " " + apellido + ", edad: " + edad;
        }
    }
}
