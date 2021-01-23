using OnlineSchool.Busness.Academico.Models;
using OnlineSchool.Busness.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSchool.Busness.Interfaces
{
    public interface IMaterialDeApoioRepository : IRepository<MaterialDeApoio>
    {
        Task<IEnumerable<MaterialDeApoio>> ObterMaterialDeApoioPorCurso(Guid cursoId);

        Task<IEnumerable<MaterialDeApoio>> ObterMateriaisDeApoioAtivos();

        Task<MaterialDeApoio> ObterMaterialApoioCurso(Guid materialId);

    }
}
