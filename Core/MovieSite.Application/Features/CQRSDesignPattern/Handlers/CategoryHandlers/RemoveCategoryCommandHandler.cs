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

        public async Task Handle(RemoveCategoryCommand command)
        {
            var value = await _dbContext.Categories.FindAsync(command.CategoryId);
            _dbContext.Categories.Remove(value);
            await _dbContext.SaveChangesAsync();
        }
    }
}
