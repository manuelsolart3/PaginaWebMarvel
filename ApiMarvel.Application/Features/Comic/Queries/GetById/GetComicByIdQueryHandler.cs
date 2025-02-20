using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.Dtos;
using ApiMarvel.Application.IRepositories;
using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Domain.Models.Comics;
using AutoMapper;

namespace ApiMarvel.Application.Features.Comic.Queries.GetById;

public class GetComicByIdQueryHandler : IQueryHandler<GetComicByIdQuery, ComicDetailsDto>
{
    private readonly IComicRepository _comicRepository;
    private readonly IMapper _mapper;

    public GetComicByIdQueryHandler(IComicRepository comicRepository, IMapper mapper)
    {
        _comicRepository = comicRepository;
        _mapper = mapper;
    }

    public async Task<Result<ComicDetailsDto>> Handle(GetComicByIdQuery request, CancellationToken cancellationToken)
    {
        var comic = await FetchData(request.Id, cancellationToken);

        if (comic is null)
        {
            return Result.Failure<ComicDetailsDto>(ComicError.DoesntExist);
        }

        return Result.Success(comic);
    }

    private async Task<ComicDetailsDto?> FetchData(Guid id, CancellationToken cancellationToken)
    {
        var comic = await _comicRepository.GetByIdAsync(id,cancellationToken);

        return comic is not null ? _mapper.Map<ComicDetailsDto>(comic) : null;
    }
}

