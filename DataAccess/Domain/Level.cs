using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataAccess.Domain
{
    public class Level
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TradeLevel> Trades { get; set; }


        public Level()
        {
            Trades = new Collection<TradeLevel>();
        }
    }
}
