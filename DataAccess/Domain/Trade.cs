using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataAccess.Domain
{
    public class Trade
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TradeLevel> Levels { get; set; }

        public Trade()
        {
            Levels = new Collection<TradeLevel>();
        }
    }
}
