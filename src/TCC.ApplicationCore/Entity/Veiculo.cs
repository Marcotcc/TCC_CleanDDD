namespace TCC.ApplicationCore.Entity
{
    public class Veiculo
    {
        public Veiculo()
        {

        }

        public int VeiculoId { get; set; }

        public string Renavam { get; set; }

        public string Placa { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
