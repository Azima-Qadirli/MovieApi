using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Commands.TagCommand;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly MovieSiteDbContext _context;

        public UpdateTagCommandHandler(MovieSiteDbContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Tags.FindAsync(request.TagId);
            value.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
