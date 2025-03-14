using MediatR;

namespace MovieSite.Application.Features.MediatorDesignPattern.Queries.CastQuery
{
    public class GetCastByIdQuery : IRequest<GetCastByIdQuery>
    {
        public int CastId { get; set; }

        public GetCastByIdQuery(int castId)
        {
            CastId = castId;
        }
    }
}
