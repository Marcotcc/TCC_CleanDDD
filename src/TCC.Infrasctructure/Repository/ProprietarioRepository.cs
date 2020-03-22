using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.Infrasctructure.Data;

namespace TCC.Infrasctructure.Repository
{
    public class ProprietarioRepository : EFRepository<Proprietario>, IProprietarioRepository
    {
        public ProprietarioRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
