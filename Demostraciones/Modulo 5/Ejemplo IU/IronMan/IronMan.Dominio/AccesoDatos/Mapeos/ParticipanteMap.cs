using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using IronMan.Dominio.Modelos;

namespace IronMan.Dominio.AccesoDatos.Mapeos
{
    public class ParticipanteMap : EntityTypeConfiguration<Participante>
    {
        public ParticipanteMap()
        {
            // Clave Primaria
            this.HasKey(t => t.Id);

            // Propiedades
            this.Property(t => t.Nombres)
                .IsRequired();

            this.Property(t => t.Apellido)
                .IsRequired();

            this.Property(t => t.Estado)
                .IsRequired();

            this.Property(t => t.Numero)
                .IsRequired();

            this.Property(t => t.Domicilio_Calle)
                .IsRequired();

            this.Property(t => t.Domicilio_Piso)
                .IsRequired();

            this.Property(t => t.Domicilio_Cuidad)
                .IsRequired();

            this.Property(t => t.Domicilio_Provincia)
                .IsRequired();

            this.Property(t => t.Domicilio_Pais)
                .IsRequired();

            this.Property(t => t.EstaHabilitado)
                .IsRequired();

            // Mapeos de tablas y columnas
            this.ToTable("Participantes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nombres).HasColumnName("Nombres").HasMaxLength(50);
            this.Property(t => t.Apellido).HasColumnName("Apellido").HasMaxLength(50);
            this.Property(t => t.FechaNacimiento).HasColumnName("FechaNacimiento");
            this.Property(t => t.Estado).HasColumnName("Estado").HasMaxLength(20);
            this.Property(t => t.Numero).HasColumnName("Numero");
            this.Property(t => t.Domicilio_Calle).HasColumnName("Domicilio_Calle").HasMaxLength(50);
            this.Property(t => t.Domicilio_Numero).HasColumnName("Domicilio_Numero");
            this.Property(t => t.Domicilio_Piso).HasColumnName("Domicilio_Piso").HasMaxLength(50);
            this.Property(t => t.Domicilio_Departamento).HasColumnName("Domicilio_Departamento");
            this.Property(t => t.Domicilio_Cuidad).HasColumnName("Domicilio_Cuidad").HasMaxLength(50);
            this.Property(t => t.Domicilio_Provincia).HasColumnName("Domicilio_Provincia").HasMaxLength(50);
            this.Property(t => t.Domicilio_Pais).HasColumnName("Domicilio_Pais").HasMaxLength(50);
            this.Property(t => t.EstaHabilitado).HasColumnName("Habilitado");
            this.Property(t => t.Prueba_Id).HasColumnName("Prueba_Id");

            // Relaciones
            this.HasRequired(t => t.Prueba)
                .WithMany(t => t.Participantes)
                .HasForeignKey(d => d.Prueba_Id);

        }
    }
}
