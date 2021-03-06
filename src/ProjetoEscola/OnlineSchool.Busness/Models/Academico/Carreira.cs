﻿using OnlineSchool.Busness.Models;
using System.Collections.Generic;

namespace OnlineSchool.Busness.Academico.Models
{
    public class Carreira : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public virtual IEnumerable<Curso> Cursos { get; set; }
    }
}
