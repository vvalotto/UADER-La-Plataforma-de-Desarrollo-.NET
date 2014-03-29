using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa14a:Programa
    {
       
        //private void emp_DatosCambiados()
        //{
        //    Console.WriteLine("Los datos fueron cambiados");
        //}

        private void emp_DatosCambiados(object sender, EventArgs e)
        {
            Console.WriteLine("Los datos fueron cambiados");
        }

		internal override void Ejecutar()
        {
            Empleados emp = new Empleados   ("Jose", "Perez", 34);
            emp.DatosCambiados += new EventHandler(emp_DatosCambiados);
            //emp.DatosCambiados += new Empleados.DatosCambiadosEventHandler(emp_DatosCambiados);
            emp.Nombre = "Nuevo Nombre";
            Console.WriteLine(emp.ToString());

            Console.ReadKey();
        }

    }


  
}
