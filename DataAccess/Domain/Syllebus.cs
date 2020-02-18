using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Domain
{
    public class Syllebus
    {
        public int Id { get; set; }
        public string SyllebusName { get; set; }
        public int TradeId { get; set; }
        public int LevelId { get; set; }

        public string DevelopmentOfficer { get; set; }
        public string Manager { get; set; }
        public DateTime ActiveDate { get; set; }

        public int? SyllebusDocId { get; set; }
        public int? TestPlanDocId { get; set; }


        [ForeignKey("TradeId")]
        public Trade Trade { get; set; }

        [ForeignKey("LevelId")]
        public Level Level { get; set; }

        [ForeignKey("SyllebusDocId")]
        public Documents SyllebusDoc { get; set; }

        [ForeignKey("TestPlanDocId")]
        public Documents TestPlanDoc { get; set; }
        


        public ICollection<SyllebusLanguage> Languages { get; set; }



        public Syllebus()
        {
            Languages = new Collection<SyllebusLanguage>();
        }
    }
}