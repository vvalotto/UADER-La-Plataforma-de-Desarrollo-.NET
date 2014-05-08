using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BAGA.Modelo;
using BAGA.DataAccess;

namespace BAGA
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EscapadaContexto>());
            InsertarDestino();
            InsertarViaje();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            Console.ReadKey();
        }

        private static void InsertarDestino()
        {
            var destino = new Destino
            {
                Pais = "Indonesia",
                Descripcion = "EcoTourism at its best in exquisite Bali",
                Nombre = "Bali"
            };
            using (var context = new EscapadaContexto())
            {
                context.Destinos.Add(destino);
                context.SaveChanges();
            }
        }

        private static void InsertarViaje()
        {
            var trip = new Viaje
            {
                CostoUSD = 800,
                FechaInicio = new DateTime(2011, 9, 1),
                FechaFin = new DateTime(2011, 9, 14)
            };
            using (var context = new EscapadaContexto())
            {
                context.Viajes
                    .Add(trip);
                context.SaveChanges();
            }
        }
    }
}
