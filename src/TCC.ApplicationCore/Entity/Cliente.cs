using System.Collections.Generic;

namespace TCC.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set;  }

        public string Email { get; set; }

        public ICollection<Veiculo> Veiculos { get; set; }
    }
}
