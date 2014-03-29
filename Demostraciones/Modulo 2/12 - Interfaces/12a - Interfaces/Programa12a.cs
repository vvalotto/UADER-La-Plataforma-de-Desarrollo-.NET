﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{ 
    //public interface IAnimal
    //{
    //    void Desplazarse();
    //    void Alimentarse();
    //    string Especie { get; set; }
    //    int Edad { get; }

    //}

    //interface IMamifero : IAnimal
    //{
    //    void Procrearse();
    //}


    //class Mamifero : IMamifero
    //{

    //    public void Procrearse()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Desplazarse()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Alimentarse()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string Especie
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //        set
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public int Edad
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}



    //1 . Declaracion de Interface y explicacion
    interface IMiInterface
    {
        void Mostrar();
        string Nombre { set; get; }
        int Edad {get;}
    }


    //2. Implementar una interfaz en una clase
    public class Gente : CaractPersonas, IMiInterface
    {
        //public string Apellidos = "Mis Apellidos";

        public void Mostrar()
        {
            Console.WriteLine(Nombre + " " + Apellidos);
        
        }

        private string nombreValor;
        public string Nombre
        {
            get
            {
                return nombreValor;
            }
            set
            {
                nombreValor = value;
            }
        }

        private int edadValor;
        public int Edad
        {
            get { return edadValor; }
        }
    }


        class Programa12a:Programa
        {
            internal override void Ejecutar()
            {
                //3. Uso de la Interfaz
                Gente objPersona = new Gente();
                objPersona.Nombre = "Alejo";
                objPersona.Mostrar();

                //4. Variables Interfaz
                IMiInterface i = objPersona;
                i.Mostrar();

                //6. Variables Objeto
                CaractPersonas a = objPersona;
                a.Apellidos = "Otros Apellidos";
                objPersona.Mostrar();
        
                Console.ReadLine();
            
        }
    }

    //5. 
    public class CaractPersonas
    {
        private string apellidosValor = "Apellidos";
        public string Apellidos
        {
            get
            {
                return apellidosValor;
            }
            set
            {
                apellidosValor = value;

            }
        }
    }
    
}
