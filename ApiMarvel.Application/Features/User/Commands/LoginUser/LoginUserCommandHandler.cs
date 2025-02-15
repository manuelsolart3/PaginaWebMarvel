using ApiMarvel.Application.Abstractions.Messaging;
using ApiMarvel.Application.Authentication;
using ApiMarvel.Domain.Abstractions;
using ApiMarvel.Domain.Models.Users;
using Microsoft.AspNetCore.Identity;


namespace ApiMarvel.Application.Features.User.Commands.LoginUser
{
    public class LoginUserCommandHandler : ICommandHandler<LoginUserCommand, string>
    {
        private readonly UserManager<ApiMarvel.Domain.Models.Users.User> _userManager;
        private readonly JwtTokenService _jwtTokenService;

        public LoginUserCommandHandler(UserManager<ApiMarvel.Domain.Models.Users.User> userManager, JwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<Result<string>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user is null || user.Identification != request.Identification)
            {
                return Result.Failure<string>(UserError.UserNotFound);
            }

            var token = _jwtTokenService.GenerateToken(user);

            return Result.Success(token);
        }
    }


}
