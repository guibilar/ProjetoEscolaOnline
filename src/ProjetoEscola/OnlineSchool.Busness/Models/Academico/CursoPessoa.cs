using OnlineSchool.Busness.Academico.Models;
using System;

namespace OnlineSchool.Busness.Models.Academico
{
    public class CursoPessoa
    {
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public Guid CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
