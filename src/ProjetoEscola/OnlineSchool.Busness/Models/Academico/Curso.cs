using OnlineSchool.Busness.Models;
using System.Collections.Generic;

namespace OnlineSchool.Busness.Academico.Models
{
    public class Curso : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal CargaHoraria { get; set; }
        public decimal Valor { get; set; }
        public IEnumerable<MaterialDeApoio> MateriaisDeApoio { get; set; }
        public IEnumerable<Pessoa> Alunos { get; set; }
        public Pessoa Instrutor { get; set; }
    }
}
