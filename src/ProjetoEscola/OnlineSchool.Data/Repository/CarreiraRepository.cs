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
    public class CarreiraRepository : Repository<Carreira>, ICarreiraRepository
    {
        public CarreiraRepository(EscolaDbContext context) : base(context) { }

        public async Task<Carreira> ObterCarreiraCursos(Guid carreiraId)
        {
            return await Db.Carreiras.AsNoTracking()
                .Include(c => c.Cursos)
                .FirstOrDefaultAsync(c => c.Id == carreiraId);
        }

        public async Task<IEnumerable<Carreira>> ObterCarreirasAtivas()
        {
            return await Db.Carreiras.AsNoTracking()
                .Where(p => p.Ativo == true)
                .ToListAsync();
        }
    }
}
