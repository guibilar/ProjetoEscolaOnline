using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Busness.Models;

namespace OnlineSchool.Data.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Sobrenome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.Property(c => c.TipoPessoa)
                .IsRequired();

            builder.Property(c => c.Ativo)
                .IsRequired();

            builder.ToTable("Pessoas");
        }
    }
}
