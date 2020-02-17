using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Domain
{
    public class TradeLevel
    {
        public int TradeId { get; set; }
        public int LevelId { get; set; }

        public virtual Trade Trade { get; set; }
        public virtual Level Level { get; set; }
    }
}
