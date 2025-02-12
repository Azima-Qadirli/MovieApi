using MovieSite.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        readonly MovieSiteDbContext _dbContext;

        public RemoveCategoryCommandHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async void Handle(RemoveCategoryCommand command)
        {
            var value = await _dbContext.Movies.FindAsync(command.CategoryId);
            _dbContext.Movies.Remove(value);
            await _dbContext.SaveChangesAsync();
        }
    }
}
