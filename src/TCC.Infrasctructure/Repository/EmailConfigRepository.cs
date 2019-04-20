using TCC.ApplicationCore.Entity;
using TCC.ApplicationCore.Interfaces.Repository;
using TCC.Infrasctructure.Data;

namespace TCC.Infrasctructure.Repository
{
    public class EmailConfigRepository : EFRepository<EmailConfig>, IEmailConfigRepository
    {
        public EmailConfigRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
