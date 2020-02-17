using DataAccess.Domain;
using DataAccess.Repositories;

namespace DataAccess.Persistence.Implementation
{
    public class LanguageRepository : Repository<Language>, ILanguageRepository
    {
        public LanguageRepository(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext Context
        {
            get { return _context as ApplicationDbContext; }
        }
    }
}
