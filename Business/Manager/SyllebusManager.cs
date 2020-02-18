using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.DTO;
using Business.Repositories;
using DataAccess;
using DataAccess.Domain;
using Microsoft.AspNetCore.Http;

namespace Business.Manager
{
    public class SyllebusManager : ISyllebusManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SyllebusManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<SyllebusDetailDto> CreateAsync(SyllebusDto syllebusDto)
        {
            var syllebus = _mapper.Map<Syllebus>(syllebusDto);
            

            _unitOfWork.Syllebus.Add(syllebus);
            await _unitOfWork.CompleteAsync();


            var result = await _unitOfWork.Syllebus.LoadWithAllRelated(syllebus.Id);
            var detail = _mapper.Map<SyllebusDetailDto>(result);
            return detail;
        }

        public async Task<IEnumerable<SyllebusDetailDto>> GetAllSyllebusAsync()
        {
            var result = await _unitOfWork.Syllebus.LoadAllWithAllRelated();
            var detail = _mapper.Map<List<SyllebusDetailDto>>(result.ToList());
            return detail;
        }

        public async Task<int> UploadFile(IFormFile file)
        {
            Documents sylDoc = new Documents();
            sylDoc.FileName = file.FileName;
            sylDoc.MimeType = file.ContentType;
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                sylDoc.FileContent = stream.ToArray();
            }

            _unitOfWork.Syllebus.UploadDoc(sylDoc);
            await _unitOfWork.CompleteAsync();

            return sylDoc.Id;
        }
    }
}