using ApiMarvel.Application.Abstractions.Messaging;

namespace ApiMarvel.Application.Features.User.Commands.AddFavoriteComic;

public record AddFavoriteComicCommand(Guid ComicId) : ICommand;

