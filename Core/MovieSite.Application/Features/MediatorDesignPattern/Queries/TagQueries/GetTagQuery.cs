using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Results.TagResults;

namespace MovieSite.Application.Features.MediatorDesignPattern.Queries.TagQuery
{
    public class GetTagQuery : IRequest<List<GetTagQueryResult>>
    {
    }
}
