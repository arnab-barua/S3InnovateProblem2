using Business.DTO;
using DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public interface ITradeManager
    {
        Task<IEnumerable<TradeDto>> GetAllTradesWithLevelsAsync();
    }
}
