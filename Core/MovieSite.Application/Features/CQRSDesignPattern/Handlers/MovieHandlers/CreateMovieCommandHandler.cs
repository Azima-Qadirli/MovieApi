using MovieSite.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieSite.Domain.Entities;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        readonly MovieSiteDbContext _dbContext;

        public CreateMovieCommandHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle(CreateMovieCommand command)
        {
            _dbContext.Movies.Add(new Movie
            {
                CoverImageUrl = command.CoverImageUrl,
                CreatedYear = command.CreatedYear,
                Description = command.Description,
                Duration = command.Duration,
                Rating = command.Rating,
                ReleaseDate = command.ReleaseDate,
                Status = command.Status,
                Title = command.Title
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
