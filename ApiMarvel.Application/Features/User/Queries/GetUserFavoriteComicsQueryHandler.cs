using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.Dtos;
using ApiMarvel.Application.IRepositories;
using ApiMarvel.Application.IServices;
using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Domain.Models.Users;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiMarvel.Application.Features.User.Queries;

public class GetUserFavoriteComicsHandler : IRequestHandler<GetUserFavoriteComicsQuery, Result<Pageable<ComicPreviewDto>>>
{
    private readonly IUserFavoriteComicRepository _userFavoriteComicRepository;
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;

    public GetUserFavoriteComicsHandler(
        IUserFavoriteComicRepository userFavoriteComicRepository,
        IMapper mapper,
        ICurrentUserService currentUserService)
    {
        _userFavoriteComicRepository = userFavoriteComicRepository;
        _mapper = mapper;
        _currentUserService = currentUserService;
    }

    public async Task<Result<Pageable<ComicPreviewDto>>> Handle(GetUserFavoriteComicsQuery request, CancellationToken cancellationToken)
    {
        var userId = _currentUserService.UserId;

        if (string.IsNullOrEmpty(userId))
            return Result.Failure<Pageable<ComicPreviewDto>>(UserError.UserNotFound);

        var favoriteComics = await FetchData((userId), request.Page, request.PageSize);

        return Result.Success(favoriteComics);
    }

    private async Task<Pageable<ComicPreviewDto>> FetchData(string userId, int page, int pageSize)
    {
        int start = pageSize * (page - 1);

        IQueryable<UserFavoriteComic> favoriteComicsQuery = _userFavoriteComicRepository.Queryable()
            .Include(ufc => ufc.Comic)
            .Where(ufc => ufc.UserId == userId);

        int totalCount = await favoriteComicsQuery.CountAsync();

        List<UserFavoriteComic> favoriteComics = await favoriteComicsQuery
            .Skip(start)
            .Take(pageSize)
            .ToListAsync();

        List<ComicPreviewDto> favoriteComicDtos = _mapper.Map<List<ComicPreviewDto>>(favoriteComics.Select(ufc => ufc.Comic));

        return new Pageable<ComicPreviewDto>
        {
            List = favoriteComicDtos,
            Count = totalCount
        };
    }
}


