using System;
using System.Collections.Generic;
using System.Text;
using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.Infrasctructure.Data;

namespace TCC.Infrasctructure.Repository
{
    public class VeiculoRepository : EFRepository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
