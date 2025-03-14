using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Results.CastResults;

namespace MovieSite.Application.Features.MediatorDesignPattern.Queries.CastQuery
{
    public class GetCastQuery : IRequest<List<GetCastQueryResult>>
    {
    }
}
