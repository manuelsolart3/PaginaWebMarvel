using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.Dtos;

namespace ApiMarvel.Application.Features.Comic.Queries.GetById;

public record GetComicByIdQuery(Guid Id) : IQuery<ComicDetailsDto>;
