using OnlineSchool.Busness.Models;
using System;

namespace OnlineSchool.Busness.Academico.Models
{
    public class MaterialDeApoio : Entity
    {
        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public string Link { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public Curso Curso { get; set; }
    }
}
