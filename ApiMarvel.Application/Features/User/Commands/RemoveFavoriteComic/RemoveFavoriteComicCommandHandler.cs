using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.IRepositories;
using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Domain.Models.Comics;

namespace ApiMarvel.Application.Features.User.Commands.RemoveFavoriteComic;

public class RemoveFavoriteComicCommandHandler : ICommandHandler<RemoveFavoriteComicCommand>
{
    private readonly IUserFavoriteComicRepository _favoriteComicRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoveFavoriteComicCommandHandler(IUserFavoriteComicRepository favoriteComicRepository, IUnitOfWork unitOfWork)
    {
        _favoriteComicRepository = favoriteComicRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(RemoveFavoriteComicCommand request, CancellationToken cancellationToken)
    {
        var favoriteComic = await _favoriteComicRepository.GetByIdAsync(request.Id, cancellationToken);
        if (favoriteComic is null)
        {
            return Result.Failure(ComicError.DoesntExist);
        }

        await _favoriteComicRepository.DeleteAsync(favoriteComic,cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}

