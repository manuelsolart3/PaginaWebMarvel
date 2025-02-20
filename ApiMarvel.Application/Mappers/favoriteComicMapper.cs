using ApiMarvel.Application.Dtos;
using ApiMarvel.Domain.Models.Users;
using AutoMapper;

namespace ApiMarvel.Application.Mappers;

public class FavoriteComicProfile : Profile
{
    public FavoriteComicProfile()
    {
        CreateMap<UserFavoriteComic, FavoriteComicPreviewDto>()
            .ForMember(dest => dest.FavoriteId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.ComicId, opt => opt.MapFrom(src => src.ComicId))  // Asegúrate de que ComicId existe en UserFavoriteComic
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Comic.Title))  // Verifica que Comic tenga la propiedad Title
            .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Comic.ImageUrl));  // Verifica que Comic tenga la propiedad ImageUrl
    }
}