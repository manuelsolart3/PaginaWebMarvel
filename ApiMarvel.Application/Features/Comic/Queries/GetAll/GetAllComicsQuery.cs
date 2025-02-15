using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.Dtos;
using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Domain.Models.Comics;

namespace ApiMarvel.Application.Features.Comic.Queries.GetAll;

public record GetAllComicsQuery (int Page, int PageSize) : IQuery<Pageable<ComicPreviewDto>>;
