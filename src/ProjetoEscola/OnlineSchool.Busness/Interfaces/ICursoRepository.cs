using OnlineSchool.Busness.Academico.Models;
using OnlineSchool.Busness.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSchool.Busness.Interfaces
{
    public interface ICursoRepository : IRepository<Curso>
    {
        Task<Curso> ObterCursosAlunos(Guid cursoId);

        Task<Curso> ObterCursosMateriais(Guid cursoId);

        Task<Curso> ObterCursosAlunoMateriais(Guid cursoId);

        Task<IEnumerable<Curso>> ObterCursosAtivos();

    }
}
