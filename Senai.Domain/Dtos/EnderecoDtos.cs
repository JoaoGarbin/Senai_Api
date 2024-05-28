using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.NovaPasta1
{
    internal class EnderecoDtos
    {
        [MaxLength(80)]
        public string Rua { get; set; }
        [MaxLength(50)]
        public string Bairro { get; set; }
        [MaxLength(60)]
        public string Cidade { get; set; }
        [MaxLength(2)]
        public string Estado { get; set; }

        public int Numero { get; set; }

    }
}
