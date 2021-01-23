using OnlineSchool.Busness.Academico.Models;
using OnlineSchool.Busness.Models.Enum;
using System.Collections.Generic;

namespace OnlineSchool.Busness.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Curso> Cursos { get; set; }

    }
}
