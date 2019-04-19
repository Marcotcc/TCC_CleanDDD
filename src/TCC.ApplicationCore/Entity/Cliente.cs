using System;
using System.Collections.Generic;
using System.Text;

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

        //public List<Veiculo> Veiculos { get; set; }
    }
}
