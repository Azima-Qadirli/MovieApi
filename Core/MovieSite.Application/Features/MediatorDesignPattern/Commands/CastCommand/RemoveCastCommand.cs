using MediatR;

namespace MovieSite.Application.Features.MediatorDesignPattern.Commands.CastCommand
{
    public class RemoveCastCommand : IRequest
    {
        public int CastId { get; set; }

        public RemoveCastCommand(int castId)
        {
            CastId = castId;
        }
    }
}
