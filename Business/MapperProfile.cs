using AutoMapper;
using Business.DTO;
using DataAccess.Domain;
using System.Linq;

namespace Business
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Language, LanguageDto>();
            CreateMap<Trade, TradeDto>()
                .ForMember(
                    dest => dest.Levels, 
                    opt => opt.MapFrom(src => src.Levels.Select(l => new LevelDto { Id = l.LevelId, Name = l.Level.Name}))
                );
        }
    }
}
