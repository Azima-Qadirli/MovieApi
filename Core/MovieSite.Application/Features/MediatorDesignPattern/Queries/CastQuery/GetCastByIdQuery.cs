using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Results.CastResults;

namespace MovieSite.Application.Features.MediatorDesignPattern.Queries.CastQuery
{
    public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
    {
        public int CastId { get; set; }

        public GetCastByIdQuery(int castId)
        {
            CastId = castId;
        }
    }
}
