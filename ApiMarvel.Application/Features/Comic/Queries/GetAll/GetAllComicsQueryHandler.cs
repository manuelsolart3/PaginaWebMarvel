using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.Dtos;
using ApiMarvel.Application.IRepositories;
using ApiMarvel.Domain.Abstractions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiMarvel.Application.Features.Comic.Queries.GetAll;

public class GetAllComicsQueryHandler : IQueryHandler<GetAllComicsQuery, Pageable<ComicPreviewDto>>
{
    private readonly IComicRepository _comicRepository;
    private readonly IMapper _mapper;

    public GetAllComicsQueryHandler(IComicRepository comicRepository, IMapper mapper)
    {
        _comicRepository = comicRepository;
        _mapper = mapper;
    }

    public async Task<Result<Pageable<ComicPreviewDto>>> Handle(GetAllComicsQuery request, CancellationToken cancellationToken)
    {
        var paginatedComics = await FetchData(request.Page, request.PageSize);
        return Result.Success(paginatedComics);
    }

    private async Task<Pageable<ComicPreviewDto>> FetchData (int page, int pageSize)
    {
        var allComics = await _comicRepository.Queryable()
            .ToListAsync();

        var allComicsDtos = _mapper.Map<List<ComicPreviewDto>>(allComics);

        int totalComicsCount = allComicsDtos.Count();

        var paginatedComicDtos = allComicsDtos
           .Skip((page - 1) * pageSize)
           .Take(pageSize)
           .ToList();

        return new Pageable<ComicPreviewDto>
        {
            List = paginatedComicDtos,
            Count = totalComicsCount
        };

    }
}
