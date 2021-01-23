using OnlineSchool.Busness.Models;
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
        public IEnumerable<MaterialDeApoio> MateriaisDeApoio { get; set; }
        public IEnumerable<Pessoa> Alunos { get; set; }
        public Carreira Carreira { get; set; }
    }
}
