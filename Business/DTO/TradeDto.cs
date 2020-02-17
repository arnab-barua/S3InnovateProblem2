using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO
{
    public class TradeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<LevelDto> Levels { get; set; }

        public TradeDto()
        {
            Levels = new List<LevelDto>();
        }
    }
}
