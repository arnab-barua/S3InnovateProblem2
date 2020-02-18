using AutoMapper;
using Business.DTO;
using Business.Repositories;
using DataAccess;
using DataAccess.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class TradeManager : ITradeManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TradeManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<TradeDto>> GetAllTradesWithLevelsAsync()
        {
            var data = await _unitOfWork.Trade.LoadRelatedLevelsAsync();
            return _mapper.Map<List<TradeDto>>(data.ToList());
        }
    }
}
