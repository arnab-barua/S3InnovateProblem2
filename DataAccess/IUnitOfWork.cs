using DataAccess.Repositories;
using System;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        ILanguageRepository Language { get; }
        ITradeRepository Trade { get; }
        ISyllebusRepository Syllebus { get; }

        int Complete();

        Task<int> CompleteAsync();
    }
}
