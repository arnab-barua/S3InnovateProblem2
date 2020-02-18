using AutoMapper;
using Business.DTO;
using DataAccess.Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Map Domain model to Dto
            CreateMap<Language, LanguageDto>();
            CreateMap<Trade, TradeDto>()
                .ForMember(
                    dest => dest.Levels, 
                    opt => opt.MapFrom(src => src.Levels.Select(l => new LevelDto { Id = l.LevelId, Name = l.Level.Name}))
                );
            CreateMap<Syllebus, SyllebusDetailDto>()
                .ForMember(dest => dest.TradeName,
                    opt => opt.MapFrom(src => src.Trade.Name))
                .ForMember(dest => dest.LevelName,
                    opt => opt.MapFrom(src => src.Level.Name))
                .ForMember(dest => dest.SyllebusDoc,
                    opt => opt.MapFrom(src => src.SyllebusDoc.FileName))
                .ForMember(dest => dest.TestPlanDoc,
                    opt => opt.MapFrom(src => src.TestPlanDoc.FileName))
                .ForMember(dest => dest.Languages,
                    opt => opt.MapFrom(src => src.Languages.Select(lan => lan.Language.Code).Join(",")))
                ;


            // Map Dto to domain

            CreateMap<SyllebusDto, Syllebus>()
                .ForMember(dest => dest.Languages,
                    opt => opt.MapFrom(src => src.LanguageIds.Select(l => new SyllebusLanguage{ LanguageId = l })));
        }
    }
}
