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

        public int ProprietarioId { get; set; }

        public Proprietario Proprietario { get; set; }
    }
}
