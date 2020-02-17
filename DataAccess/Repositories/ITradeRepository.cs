using DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ITradeRepository : IRepository<Trade>
    {
        Task<IEnumerable<Trade>> LoadRelatedLevelsAsync();
    }
}
