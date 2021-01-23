using OnlineSchool.Busness.Academico.Models;
using OnlineSchool.Busness.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSchool.Busness.Interfaces
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Task<IEnumerable<Pessoa>> ObterPessoasPorCurso(Guid cursoId);

        Task<IEnumerable<Pessoa>> ObterPessoasAtivas();

        Task<Pessoa> ObterPessoaCurso(Guid pessoaId);

    }
}
