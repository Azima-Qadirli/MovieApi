using MovieSite.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieSite.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieSiteDbContext _dbContext;

        public GetMovieByIdQueryHandler(MovieSiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetMovieByIdQueryResults> Handle(GetMovieById query)
        {
            var value = await _dbContext.Movies.FindAsync(query.MovieId);
            return new GetMovieByIdQueryResults
            {
                CreatedYear = value.CreatedYear,
                CoverImageUrl = value.CoverImageUrl,
                Description = value.Description,
                Duration = value.Duration,
                Rating = value.Rating,
                ReleaseDate = value.ReleaseDate,
                Status = value.Status,
                Title = value.Title
            };
        }
    }
}
