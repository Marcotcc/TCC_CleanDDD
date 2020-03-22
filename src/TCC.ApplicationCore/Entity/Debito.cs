using System;

namespace TCC.ApplicationCore.Entity
{
    public class Debito
    {
        public int DebitoId { get; set; }

        public string Renavam { get; set; }

        public TipoDebito TipoDebito { get; set; }

        public DateTime Vencimento { get; set; }

        public decimal Valor { get; set; }

        public bool EmailEnviado { get; set; }
    }

    public enum TipoDebito : int
    {
        Multa = 0,
        Licensiamento = 1,
        IPVA = 2
    }
}
