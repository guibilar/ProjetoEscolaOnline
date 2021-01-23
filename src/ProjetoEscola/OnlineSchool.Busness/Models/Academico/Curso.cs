using OnlineSchool.Busness.Models;
using OnlineSchool.Busness.Models.Academico;
using System;
using System.Collections.Generic;

namespace OnlineSchool.Busness.Academico.Models
{
    public class Curso : Entity
    {
        public Guid CarreiraId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal CargaHoraria { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public virtual IEnumerable<MaterialDeApoio> MateriaisDeApoio { get; set; }
        public virtual IEnumerable<CursoPessoa> Alunos { get; set; }
        public Carreira Carreira { get; set; }
    }
}
