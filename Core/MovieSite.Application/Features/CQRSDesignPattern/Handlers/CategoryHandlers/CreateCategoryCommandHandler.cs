using MovieSite.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieSite.Domain.Entities;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        readonly MovieSiteDbContext _dbContext;

        public CreateCategoryCommandHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async void Handle(CreateCategoryCommand command)
        {
            _dbContext.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
