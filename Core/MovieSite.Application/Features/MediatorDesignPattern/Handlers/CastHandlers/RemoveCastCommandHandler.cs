using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Commands.CastCommand;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class RemoveCastCommandHandler : IRequestHandler<RemoveCastCommand>
    {
        private readonly MovieSiteDbContext _context;

        public RemoveCastCommandHandler(MovieSiteDbContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Casts.FindAsync(request.CastId);
            _context.Casts.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
