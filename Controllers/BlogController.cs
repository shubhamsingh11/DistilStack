using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/blogs")]
public class BlogsController : ControllerBase
{
    private readonly IMediator _mediator;

    public BlogsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        CreateBlogPostCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}