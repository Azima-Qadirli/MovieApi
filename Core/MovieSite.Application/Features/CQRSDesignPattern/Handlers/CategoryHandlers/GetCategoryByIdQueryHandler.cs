using MovieSite.Application.Features.CQRSDesignPattern.Queries.CategoryQueries;
using MovieSite.Application.Features.CQRSDesignPattern.Results.CategoryResults;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly MovieSiteDbContext _dbContext;

        public GetCategoryByIdQueryHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryById query)
        {
            var value = await _dbContext.Categories.FindAsync(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
