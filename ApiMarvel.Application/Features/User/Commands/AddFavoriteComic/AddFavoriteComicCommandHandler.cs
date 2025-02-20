using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.IRepositories;
using ApiMarvel.Application.IServices;
using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Domain.Models.Comics;
using ApiMarvel.Domain.Models.Users;
using MediatR;

namespace ApiMarvel.Application.Features.User.Commands.AddFavoriteComic;

public class AddFavoriteComicHandler : ICommandHandler<AddFavoriteComicCommand>
{
    private readonly IUserFavoriteComicRepository _favoriteComicRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;

    public AddFavoriteComicHandler(IUserFavoriteComicRepository favoriteComicRepository, IUnitOfWork unitOfWork, ICurrentUserService currentUserService)
    {
        _favoriteComicRepository = favoriteComicRepository;
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
    }

    public async Task<Result> Handle(AddFavoriteComicCommand request, CancellationToken cancellationToken)
    {
        var userId = _currentUserService.UserId;

        var exists = await _favoriteComicRepository
            .ExistsAsync(userId, request.ComicId, cancellationToken);

        if (exists)
        {
            return Result.Failure(ComicError.alreadyIsYourFavorite);
        }

        var favoriteComic = new UserFavoriteComic(
             Guid.NewGuid(),
             userId,
             request.ComicId
            );
        

        await _favoriteComicRepository.AddAsync(favoriteComic, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
}

