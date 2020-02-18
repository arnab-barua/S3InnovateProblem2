using DataAccess.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence
{
    public class ApplicationDbContext : DbContext
    {

        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Trade> Trades { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Syllebus> Syllebuses { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradeLevel>().HasKey(tl => new { tl.TradeId, tl.LevelId });
            modelBuilder.Entity<SyllebusLanguage>().HasKey(sl => new { sl.SyllebusId, sl.LanguageId });
        }
       
    }
}
