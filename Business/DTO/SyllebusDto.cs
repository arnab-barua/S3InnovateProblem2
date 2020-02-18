using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Business.DTO
{
    public class SyllebusDto
    {
        public int Id { get; set; }
        public string SyllebusName { get; set; }
        public int TradeId { get; set; }
        public int LevelId { get; set; }

        public string DevelopmentOfficer { get; set; }
        public string Manager { get; set; }
        public DateTime ActiveDate { get; set; }

        public List<int> LanguageIds { get; set; }

        public int? SyllebusDocId { get; set; }
        public int? TestPlanDocId { get; set; }

        public SyllebusDto()
        {
            LanguageIds = new List<int>();
        }
    }
}