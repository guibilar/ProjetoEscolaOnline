using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Busness.Academico.Models;

namespace OnlineSchool.Data.Mappings
{
    public class MaterialsDeApoioMapping : IEntityTypeConfiguration<MaterialDeApoio>
    {
        public void Configure(EntityTypeBuilder<MaterialDeApoio> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Link)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Ativo)
                .IsRequired();

            builder.ToTable("MateriaisDeApoio");
        }

    }
}
