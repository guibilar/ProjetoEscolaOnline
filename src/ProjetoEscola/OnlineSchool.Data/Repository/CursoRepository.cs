using Microsoft.EntityFrameworkCore;
using OnlineSchool.Busness.Academico.Models;
using OnlineSchool.Busness.Interfaces;
using OnlineSchool.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool.Data.Repository
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursoRepository(EscolaDbContext context) : base(context) { }

        public async Task<Curso> ObterCursosAlunoMateriais(Guid cursoId)
        {
            return await Db.Cursos.AsNoTracking()
                .Include(c => c.Alunos)
                .Include(c => c.MateriaisDeApoio)
                .FirstOrDefaultAsync(c => c.Id == cursoId);
        }

        public async Task<Curso> ObterCursosAlunos(Guid cursoId)
        {
            return await Db.Cursos.AsNoTracking()
                .Include(c => c.Alunos)
                .FirstOrDefaultAsync(c => c.Id == cursoId);
        }

        public async Task<IEnumerable<Curso>> ObterCursosAtivos()
        {
            return await Db.Cursos.AsNoTracking()
                .Where(p => p.Ativo == true)
                .ToListAsync();
        }

        public async Task<Curso> ObterCursosMateriais(Guid cursoId)
        {
            return await Db.Cursos.AsNoTracking()
                .Include(c => c.MateriaisDeApoio)
                .FirstOrDefaultAsync(c => c.Id == cursoId);
        }
    }
}
