using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DTO;
using Microsoft.AspNetCore.Http;

namespace Business.Repositories
{
    public interface ISyllebusManager
    {
        Task<SyllebusDetailDto> CreateAsync(SyllebusDto syllebusDto);
        Task<IEnumerable<SyllebusDetailDto>> GetAllSyllebusAsync();

        Task<int> UploadFile(IFormFile file);
    }
}