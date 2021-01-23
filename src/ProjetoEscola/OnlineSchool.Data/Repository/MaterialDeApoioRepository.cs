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
    public class MaterialDeApoioRepository : Repository<MaterialDeApoio>, IMaterialDeApoioRepository
    {
        public MaterialDeApoioRepository(EscolaDbContext context) : base(context) { }

        public async Task<MaterialDeApoio> ObterMaterialApoioCurso(Guid materialId)
        {
            return await Db.MateriaisDeApoio.Include(c=>c.Curso)
                .FirstOrDefaultAsync(c=>c.Id == materialId);
        }

        public async Task<IEnumerable<MaterialDeApoio>> ObterMateriaisDeApoioAtivos()
        {
            return await Db.MateriaisDeApoio.AsNoTracking()
                            .Where(p => p.Ativo == true)
                            .ToListAsync();
        }

        public async Task<IEnumerable<MaterialDeApoio>> ObterMaterialDeApoioPorCurso(Guid cursoId)
        {
            return await Db.MateriaisDeApoio.AsNoTracking()
                .Where(c => c.CursoId == cursoId)
                .ToListAsync();
        }
    }
}
