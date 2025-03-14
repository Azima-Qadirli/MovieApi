using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieSite.Application.Features.MediatorDesignPattern.Queries.CastQuery;
using MovieSite.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieSiteDbContext _context;

        public GetCastQueryHandler(MovieSiteDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                CastId = x.CastId,
                Biography = x.Biography,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Surname = x.Surname,
                Overview = x.Overview,
                Title = x.Title
            }).ToList();
        }
    }
}
