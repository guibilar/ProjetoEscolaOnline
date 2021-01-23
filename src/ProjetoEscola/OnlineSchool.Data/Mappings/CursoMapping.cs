using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Busness.Academico.Models;

namespace OnlineSchool.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.CargaHoraria)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.Property(c => c.Valor)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.Property(c => c.Ativo)
                .IsRequired();

            // 1 : N => Curso : MaterialDeApoio
            builder.HasMany(f => f.MateriaisDeApoio)
               .WithOne(p => p.Curso)
               .HasForeignKey(p => p.CursoId);

            builder.ToTable("Cursos");
        }

    }
}
