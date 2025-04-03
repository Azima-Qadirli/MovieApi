using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieSite.Application.Features.MediatorDesignPattern.Queries.TagQuery;
using MovieSite.Application.Features.MediatorDesignPattern.Results.TagResults;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly MovieSiteDbContext _context;

        public GetTagQueryHandler(MovieSiteDbContext context)
        {
            _context = context;
        }
        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.ToListAsync();
            return values.Select(x => new GetTagQueryResult
            {
                Title = x.Title,
                TagId = x.TagId
            }).ToList();
        }
    }
}
