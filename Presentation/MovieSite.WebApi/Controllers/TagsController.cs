using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieSite.Application.Features.MediatorDesignPattern.Commands.TagCommand;
using MovieSite.Application.Features.MediatorDesignPattern.Queries.TagQuery;

namespace MovieSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagsList()
        {
            var values = await _mediator.Send(new GetTagQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Tag was created successfully!");
        }

        [HttpGet("GetTagById")]
        public async Task<IActionResult> GetTagById(int id)
        {
            var value = await _mediator.Send(new GetTagByIdQuery(id));
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTag(int id)
        {
            await _mediator.Send(new RemoveTagCommand(id));
            return Ok("Tag was deleted successfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Tag was updated successfully!");
        }
    }
}
