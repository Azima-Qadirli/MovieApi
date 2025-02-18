using MovieSite.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        readonly MovieSiteDbContext _dbContext;

        public UpdateCategoryCommandHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var value = await _dbContext.Categories.FindAsync(command.CategoryId);
            value.CategoryName = command.CategoryName;
            await _dbContext.SaveChangesAsync();
        }
    }
}
