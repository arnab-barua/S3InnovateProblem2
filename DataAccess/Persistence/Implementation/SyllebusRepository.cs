using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Domain;
using DataAccess.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence.Implementation
{
    public class SyllebusRepository : Repository<Syllebus>, ISyllebusRepository
    {
        public SyllebusRepository(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext Context
        {
            get { return _context as ApplicationDbContext; }
        }

        public async Task<Syllebus> LoadWithAllRelated(int id)
        {
            var syllebus = Context.Syllebuses
                .Include(a => a.Trade)
                .Include(a => a.Level)
                .Include(a => a.SyllebusDoc)
                .Include(a => a.TestPlanDoc)
                .Include(a => a.Languages)
                .ThenInclude(lan => lan.Language)
                .FirstOrDefault(a => a.Id == id);

            return syllebus;


        }

        public async Task<IEnumerable<Syllebus>> LoadAllWithAllRelated()
        {
            var data = await Context.Syllebuses
                .Include(a => a.Trade)
                .Include(a => a.Level)
                .Include(a => a.SyllebusDoc)
                .Include(a => a.TestPlanDoc)
                .Include(a => a.Languages)
                .ThenInclude(lan => lan.Language)
                .ToListAsync();

            return data;
        }

        public void UploadDoc(Documents doc)
        {
            Context.Documents.Add(doc);
        }
    }
}