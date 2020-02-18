using DataAccess.Domain;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DataAccess.Persistence.Implementation
{
    public class TradeRepository : Repository<Trade>, ITradeRepository
    {
        public TradeRepository(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext Context
        {
            get { return _context as ApplicationDbContext; }
        }

        public async Task<IEnumerable<Trade>> LoadRelatedLevelsAsync()
        {
            var data = await Context.Trades
                .Include(a => a.Levels)
                    .ThenInclude(l => l.Level)
                .ToListAsync();
            return data;
        }
    }
}
