using Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public interface ILanguageManager
    {
        Task<IEnumerable<LanguageDto>> GetAllAsync();
    }
}
