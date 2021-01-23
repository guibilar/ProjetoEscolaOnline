using OnlineSchool.Busness.Academico.Models;
using OnlineSchool.Busness.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSchool.Busness.Interfaces
{
    public interface ICarreiraRepository : IRepository<Carreira>
    {
        Task<Carreira> ObterCarreiraCursos(Guid carreiraId);

        Task<IEnumerable<Carreira>> ObterCarreirasAtivas();

    }
}
