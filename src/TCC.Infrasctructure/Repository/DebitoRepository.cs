using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.Infrasctructure.Data;

namespace TCC.Infrasctructure.Repository
{
    public class DebitoRepository : EFRepository<Debito>, IDebitoRepository
    {
        public DebitoRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
