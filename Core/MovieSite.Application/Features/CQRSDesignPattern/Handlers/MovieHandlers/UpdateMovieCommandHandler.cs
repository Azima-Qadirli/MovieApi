using MovieSite.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        readonly MovieSiteDbContext _dbContext;

        public UpdateMovieCommandHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _dbContext.Movies.FindAsync(command.MovieId);
            value.CoverImageUrl = command.CoverImageUrl;
            value.CreatedYear = command.CreatedYear;
            value.Status = command.Status;
            value.Title = command.Title;
            value.Description = command.Description;
            value.Rating = command.Rating;
            value.Duration = command.Duration;
            value.ReleaseDate = command.ReleaseDate;
            await _dbContext.SaveChangesAsync();
        }
    }
}
