using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.Infrasctructure.Data;

namespace TCC.Infrasctructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
