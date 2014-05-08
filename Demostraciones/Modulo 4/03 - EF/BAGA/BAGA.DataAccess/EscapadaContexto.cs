using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using BAGA.Modelo;

namespace BAGA.DataAccess
{
    public class EscapadaContexto: DbContext
    {
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Hospedaje> Hospedajes { get; set; }
        public DbSet<Viaje> Viajes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DestinoConfiguracion());
            modelBuilder.Configurations.Add(new HospedajeConfiguracion());
            modelBuilder.Configurations.Add(new ViajeConfiguracion());
        } 

    }

    public class DestinoConfiguracion :EntityTypeConfiguration<Destino>
    {
        public DestinoConfiguracion()
        {
            Property(d => d.Nombre).IsRequired();
            Property(d => d.Descripcion).HasMaxLength(500);
            Property(d => d.Foto).HasColumnType("image");
        }
    }

    public class HospedajeConfiguracion :EntityTypeConfiguration<Hospedaje>
    {
        public HospedajeConfiguracion()
        {
            Property(l => l.Nombre).IsRequired().HasMaxLength(200);
        }
    }

    public class ViajeConfiguracion: EntityTypeConfiguration<Viaje>
    {
        public ViajeConfiguracion()
        {
            HasKey(t => t.Identificador)
                .Property(t => t.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
