using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieSite.Application.Features.MediatorDesignPattern.Commands.CastCommand;
using MovieSite.Application.Features.MediatorDesignPattern.Queries.CastQuery;

namespace MovieSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult CastList()
        {
            var value = _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCast(CreateCastCommand command)
        {
            _mediator.Send(command);
            return Ok("Creating cast is successfully!");
        }

        [HttpDelete]
        public IActionResult DeleteCast(int id)
        {
            _mediator.Send(new RemoveCastCommand(id));
            return Ok("Removing cast is successfully!");
        }

        [HttpGet("GetCastById")]
        public IActionResult GetCastById(int id)
        {
            var value = _mediator.Send(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCast(UpdateCastCommand command)
        {
            _mediator.Send(command);
            return Ok("Updating cast is successfully!");
        }


    }
}
