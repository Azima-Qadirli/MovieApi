using MediatR;

namespace MovieSite.Application.Features.MediatorDesignPattern.Commands.TagCommand
{
    public class RemoveTagCommand : IRequest
    {
        public int TagId { get; set; }

        public RemoveTagCommand(int tagId)
        {
            TagId = tagId;
        }
    }
}
