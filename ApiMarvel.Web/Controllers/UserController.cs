using ApiMarvel.Application.Features.User.Commands.CreateUser;
using ApiMarvel.Application.Features.User.Commands.LoginUser;
using ApiMarvel.Application.Features.User.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarvel.Web.Controllers;


[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> CreateUser (CreateUserCommand command)
    {
        var result = await _mediator.Send(command);
        if (result.IsSuccess)
        {
            return Ok("User Created Succesfuly");
        }
        else
        {
            return BadRequest(result.Error);
        }
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] LoginUserCommand command, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(command, cancellationToken);

        return result.IsSuccess
            ? Ok(new { Token = result.Data })
            : BadRequest(new { Error = result.ErrorCode });
    }

    [HttpGet("favorite-comics")]
    public async Task<IActionResult> GetUserFavoriteComics([FromQuery] GetUserFavoriteComicsQuery query, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(query, cancellationToken);

        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }
        else
        {
            return BadRequest(result.Error);
        }
    }


}
