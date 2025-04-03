using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Commands.TagCommand;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand>
    {
        private readonly MovieSiteDbContext _context;

        public RemoveTagCommandHandler(MovieSiteDbContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Tags.FindAsync(request.TagId);
            _context.Tags.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
