using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.Dtos;
using ApiMarvel.Domain.Abstractions;

namespace ApiMarvel.Application.Features.User.Queries;

public record GetUserFavoriteComicsQuery(string UserId, int Page, int PageSize) : IQuery<Pageable<ComicPreviewDto>>;

