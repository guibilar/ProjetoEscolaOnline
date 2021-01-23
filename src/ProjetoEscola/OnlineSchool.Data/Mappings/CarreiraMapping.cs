using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Busness.Academico.Models;

namespace OnlineSchool.Data.Mappings
{
    public class CarreiraMapping : IEntityTypeConfiguration<Carreira>
    {
        public void Configure(EntityTypeBuilder<Carreira> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Ativo)
                .IsRequired();

            // 1 : N => Carreira : Cursoss
            builder.HasMany(f => f.Cursos)
               .WithOne(p => p.Carreira)
               .HasForeignKey(p => p.CarreiraId);

            builder.ToTable("Carreiras");
        }

    }
}
