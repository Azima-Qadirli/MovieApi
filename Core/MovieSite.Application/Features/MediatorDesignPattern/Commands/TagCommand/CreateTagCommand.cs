using MediatR;

namespace MovieSite.Application.Features.MediatorDesignPattern.Commands.TagCommand
{
    public class CreateTagCommand : IRequest
    {
        public string Title { get; set; }
    }
}
