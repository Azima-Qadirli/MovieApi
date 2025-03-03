using Microsoft.AspNetCore.Mvc;
using MovieSite.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieSite.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers;
using MovieSite.Application.Features.CQRSDesignPattern.Queries.MovieQueries;

namespace MovieSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        readonly CreateMovieCommandHandler _createMovieCommandHandler;
        readonly GetMovieByIdQueryHandler _getMovieByIdQueryHandler;
        readonly GetMovieQueryHandler _getMovieQueryHandler;
        readonly UpdateMovieCommandHandler _updateMovieCommandHandler;
        readonly RemoveMovieCommandHandler _removeMovieCommandHandler;

        public MoviesController(CreateMovieCommandHandler createMovieCommandHandler, GetMovieByIdQueryHandler getMovieByIdQueryHandler, GetMovieQueryHandler getMovieQueryHandler, UpdateMovieCommandHandler updateMovieCommandHandler, RemoveMovieCommandHandler removeMovieCommandHandler)
        {
            _createMovieCommandHandler = createMovieCommandHandler;
            _getMovieByIdQueryHandler = getMovieByIdQueryHandler;
            _getMovieQueryHandler = getMovieQueryHandler;
            _updateMovieCommandHandler = updateMovieCommandHandler;
            _removeMovieCommandHandler = removeMovieCommandHandler;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieCommand command)
        {
            await _createMovieCommandHandler.Handle(command);
            return Ok("Movie is created successfully!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _removeMovieCommandHandler.Handle(new RemoveMovieCommand(id));
            return Ok("Movie is deleted successfully!");
        }

        [HttpGet("GetMovie")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var value = await _getMovieByIdQueryHandler.Handle(new GetMovieById(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
        {
            await _updateMovieCommandHandler.Handle(command);
            return Ok("Movie is updated successfully!");
        }
    }
}
