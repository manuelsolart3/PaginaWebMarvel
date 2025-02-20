using ApiMarvel.Application.Features.Comic.Queries.GetAll;
using ApiMarvel.Application.Features.Comic.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarvel.Web.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ComicController : ControllerBase
{
    private readonly IMediator _mediator;

    public ComicController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all")]
    public async Task<ActionResult> GetAllComics([FromQuery] GetAllComicsQuery query, CancellationToken cancellationToken)
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

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetComicById(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetComicByIdQuery(id);
        var result = await _mediator.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return NotFound(result.Error);
        }

        return Ok(result.Value);
    }
}
