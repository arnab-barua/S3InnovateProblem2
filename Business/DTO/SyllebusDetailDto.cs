using System;

namespace Business.DTO
{
    public class SyllebusDetailDto
    {
        public int Id { get; set; }
        public string SyllebusName { get; set; }
        public int TradeId { get; set; }
        public string TradeName { get; set; }

        public int LevelId { get; set; }
        public string LevelName { get; set; }

        public string DevelopmentOfficer { get; set; }
        public string Manager { get; set; }
        public DateTime ActiveDate { get; set; }

        public string Languages { get; set; }

        public int? SyllebusDocId { get; set; }
        public string SyllebusDoc { get; set; }
        public int? TestPlanDocId { get; set; }
        public string TestPlanDoc { get; set; }
    }
}