using ApiMarvel.Application.Dtos;
using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;
using AutoMapper;

namespace ApiMarvel.Application.Mappers;

public class ComicMapper : Profile
{
    public ComicMapper()
    {
        CreateMap<Comic, ComicPreviewDto>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
           .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl));

        CreateMap<Comic, ComicDetailsDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
            .ForMember(dest => dest.Reference, opt => opt.MapFrom(src => src.Reference))
            .ForMember(dest => dest.Pages, opt => opt.MapFrom(src => src.Pages));
    }
}
