using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TCC.ApplicationCore.Entity
{
    public class Proprietario
    {
        public Proprietario()
        {

        }

        public int ProprietarioId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string CpfCnpj { get; set; }

        [Required]
        public string Telefone { get; set;  }

        [Required]
        public string Email { get; set; }

        public ICollection<Veiculo> Veiculos { get; set; }
    }
}
