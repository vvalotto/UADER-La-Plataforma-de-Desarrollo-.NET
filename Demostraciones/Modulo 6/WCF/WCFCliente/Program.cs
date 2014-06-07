using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFCliente.CalcServicio;
using System.ServiceModel;



namespace WCFCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraServicioClient miServicio = new CalculadoraServicioClient();
            Resultado _res;
           _res =  miServicio.Sumar(5.10m, 6.50m);
            if (!_res.Error)
            {
                Console.WriteLine("Suma: {0}:", _res.Valor);
            }
            else
            {
                Console.WriteLine("Suma con error: {0}", _res.Mensaje);
            }

            _res = miServicio.Restar(50m, 90m);
            if (!_res.Error)
            {
                Console.WriteLine("Resta: {0}:", _res.Valor);
            }
            else
            {
                Console.WriteLine("Resta con error: {0}", _res.Mensaje);
            }

            _res = miServicio.Multiplicar(10.5m, 23.56m);
            if (!_res.Error)
            {
                Console.WriteLine("Multiplicación: {0}:", _res.Valor);
            }
            else
            {
                Console.WriteLine("Multiplicación con error: {0}", _res.Mensaje);
            }

            _res = miServicio.Dividir(10.5m, 0m);
            if (!_res.Error)
            {
                Console.WriteLine("División: {0}:", _res.Valor);
            }
            else
            {
                Console.WriteLine("División con error: {0}", _res.Mensaje);
            }
            

            Console.ReadKey();
        }
    }
}
