using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IronMan.Dominio.Modelos;
using IronMan.Dominio.AccesoDatos.Mapeos;

namespace IronMan.Dominio.AccesoDatos
{
    public partial class IronManContext : DbContext
    {
        static IronManContext()
        {
            //Database.SetInitializer<IronManContext>(null);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<IronManContext>());
        }

        public IronManContext()
            : base("Name=IronManContext")
        {
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Prueba> Pruebas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventoMap());
            modelBuilder.Configurations.Add(new ParticipanteMap());
            modelBuilder.Configurations.Add(new PruebaMap());
        }
    }
}
