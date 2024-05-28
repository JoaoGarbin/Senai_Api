
using System.ComponentModel.DataAnnotations;

namespace Senai.Domain.Entidades
{
    public class Escola : BaseEntity
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; }

        public long EscolaId { get; set; }

        public Endereco Endereco { get; set; }

        public List<Classe> Classes { get; set; }

        public List<Professor> Professores { get; set; }
    }
}
