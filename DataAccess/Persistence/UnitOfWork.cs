using System.Threading.Tasks;
using DataAccess.Persistence.Implementation;
using DataAccess.Repositories;

namespace DataAccess.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;



        public ILanguageRepository Language { get; private set; }
        public ITradeRepository Trade { get; private set; }



        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Language = new LanguageRepository(_context);
            Trade = new TradeRepository(_context);
        }



        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
