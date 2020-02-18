using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
    public interface ISyllebusRepository : IRepository<Syllebus>
    {
        Task<Syllebus> LoadWithAllRelated(int id);
        Task<IEnumerable<Syllebus>> LoadAllWithAllRelated();
        void UploadDoc(Documents doc);
    }
}