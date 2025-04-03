using MediatR;

namespace MovieSite.Application.Features.MediatorDesignPattern.Commands.TagCommand
{
    public class UpdateTagCommand : IRequest
    {
        public int TagId { get; set; }
        public string Title { get; set; }
    }
}
