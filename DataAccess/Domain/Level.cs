using System.Collections.Generic;

namespace DataAccess.Domain
{
    public class Level
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TradeLevel> Trades { get; set; }


        public Level()
        {
            Trades = new HashSet<TradeLevel>();
        }
    }
}
