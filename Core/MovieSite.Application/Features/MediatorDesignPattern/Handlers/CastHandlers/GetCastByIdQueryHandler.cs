using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Queries.CastQuery;
using MovieSite.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {
        private readonly MovieSiteDbContext _context;

        public GetCastByIdQueryHandler(MovieSiteDbContext context)
        {
            _context = context;
        }

        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastId);
            return new GetCastByIdQueryResult
            {
                CastId = values.CastId,
                Biography = values.Biography,
                ImageUrl = values.ImageUrl,
                Name = values.Name,
                Overview = values.Overview,
                Surname = values.Surname,
                Title = values.Title
            };
        }
    }
}
