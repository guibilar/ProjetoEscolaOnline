using OnlineSchool.Busness.Models.Enum;

namespace OnlineSchool.Busness.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public bool Ativo { get; set; }

    }
}
