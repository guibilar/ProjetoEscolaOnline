using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Busness.Models.Academico;

namespace OnlineSchool.Data.Mappings
{
    public class CursoPessoaMapping : IEntityTypeConfiguration<CursoPessoa>
    {
        public void Configure(EntityTypeBuilder<CursoPessoa> builder)
        {
            builder.HasKey(cp => new { cp.PessoaId, cp.CursoId });

            builder.HasOne(cp => cp.Pessoa)
                .WithMany(c => c.Cursos)
                .HasForeignKey(cp => cp.CursoId);

            builder.HasOne(cp => cp.Curso)
                .WithMany(p => p.Alunos)
                .HasForeignKey(cp => cp.PessoaId);

            builder.ToTable("CursosPessoas");
        }
    }
}
