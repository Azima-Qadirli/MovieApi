using Microsoft.EntityFrameworkCore;
using MovieSite.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieSiteDbContext _context;

        public GetMovieQueryHandler(MovieSiteDbContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResults>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x => new GetMovieQueryResults
            {
                MovieId = x.MovieId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedYear = x.CreatedYear,
                Description = x.Description,
                Duration = x.Duration,
                Rating = x.Rating,
                ReleaseDate = x.ReleaseDate,
                Status = x.Status,
                Title = x.Title
            }).ToList();
        }
    }
}
