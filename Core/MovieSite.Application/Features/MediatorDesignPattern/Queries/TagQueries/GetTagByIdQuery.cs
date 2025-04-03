using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Results.TagResults;

namespace MovieSite.Application.Features.MediatorDesignPattern.Queries.TagQuery
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int TagId { get; set; }

        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }
    }
}
