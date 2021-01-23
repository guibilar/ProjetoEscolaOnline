using Microsoft.EntityFrameworkCore;
using OnlineSchool.Busness.Interfaces;
using OnlineSchool.Busness.Models;
using OnlineSchool.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool.Data.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(EscolaDbContext context) : base(context) { }

        public async Task<Pessoa> ObterPessoaCursos(Guid pessoaId)
        {
            return await Db.Pessoas.AsNoTracking()
                .Include(c => c.Cursos)
                .FirstOrDefaultAsync(p => p.Id == pessoaId);
        }

        public async Task<IEnumerable<Pessoa>> ObterPessoasAtivas()
        {
            return await Db.Pessoas.AsNoTracking()
                .Where(p => p.Ativo == true)
                .ToListAsync();
        }

        public async Task<IEnumerable<Pessoa>> ObterPessoasPorCurso(Guid cursoId)
        {
            return await Db.Pessoas.AsNoTracking()
                .Where(c => c.Cursos.Any(z=> z.CursoId == cursoId))
                .ToListAsync();
        }
    }
}
