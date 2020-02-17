using AutoMapper;
using Business.DTO;
using Business.Repositories;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class LanguageManager : ILanguageManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LanguageManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<LanguageDto>> GetAllAsync()
        {
            var languages = await _unitOfWork.Language.GetAllAsync();
            return _mapper.Map<List<LanguageDto>>(languages.ToList());
        }
    }
}
