using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Domain.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace ApiMarvel.Application.Features.User.Commands.CreateUser;

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApiMarvel.Domain.Models.Users.User> _userManager;

    public CreateUserCommandHandler(IUnitOfWork unitOfWork, UserManager<ApiMarvel.Domain.Models.Users.User> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = ApiMarvel.Domain.Models.Users.User.Create(
            request.FullName,
            request.Identification,
            request.Email);
        user.UserName = request.Email;


        var result = await _userManager.CreateAsync(user);

        if (!result.Succeeded)
        {
            return Result.Failure(UserError.CreationFailed);
        }
        return Result.Success();
    }
}
