using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    public class Empleado : IComparable
    {
        public string Nombre;
        public Empleado() { }
        public Empleado(string nombre)
        {
            this.Nombre = nombre;
        }
        public int CompareTo(object obj)
        {
            if (obj is Empleado)
            {
                Empleado e1 = ((Empleado)obj);
                return String.Compare(this.Nombre, e1.Nombre);
            }
            else
                return 0;
        }
    }
    class Programa12b:Programa
    {
        internal override void Ejecutar()

        {
            // Una colección de datos del tipo Empleado
            List<Empleado> empleados = new List<Empleado>();

            // Añadimos varios empleados a la colección
            empleados.Add(new Empleado("Pepe"));
            empleados.Add(new Empleado("Bernardo"));
            empleados.Add(new Empleado("Juan"));
            empleados.Add(new Empleado("Ana"));

            // La clasificamos
            empleados.Sort();
            
            // Mostramos los nombres clasificados
            foreach (Empleado e1 in empleados)
                Console.WriteLine(e1.Nombre);

            Console.ReadLine();

        }
    }
}
