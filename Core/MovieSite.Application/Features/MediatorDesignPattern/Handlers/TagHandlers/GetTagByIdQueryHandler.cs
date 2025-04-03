using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Queries.TagQuery;
using MovieSite.Application.Features.MediatorDesignPattern.Results.TagResults;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly MovieSiteDbContext _context;

        public GetTagByIdQueryHandler(MovieSiteDbContext context)
        {
            _context = context;
        }

        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);
            return new GetTagByIdQueryResult
            {
                Title = values.Title
            };
        }
    }
}
