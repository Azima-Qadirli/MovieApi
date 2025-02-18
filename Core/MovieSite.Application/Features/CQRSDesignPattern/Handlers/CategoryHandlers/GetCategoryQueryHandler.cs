using Microsoft.EntityFrameworkCore;
using MovieSite.Application.Features.CQRSDesignPattern.Results.CategoryResults;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly MovieSiteDbContext _dbContext;

        public GetCategoryQueryHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _dbContext.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToList();
        }
    }
}
