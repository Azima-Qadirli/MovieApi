using MovieSite.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        readonly MovieSiteDbContext _dbContext;

        public RemoveMovieCommandHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async void Handle(RemoveMovieCommand command)
        {
            var value = await _dbContext.Movies.FindAsync(command.MovieId);
            _dbContext.Movies.Remove(value);
            await _dbContext.SaveChangesAsync();
        }
    }
}
