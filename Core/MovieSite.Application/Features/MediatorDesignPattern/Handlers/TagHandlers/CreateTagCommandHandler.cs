using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Commands.TagCommand;
using MovieSite.Domain.Entities;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly MovieSiteDbContext _context;

        public CreateTagCommandHandler(MovieSiteDbContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            await _context.Tags.AddAsync(new Tag
            {
                Title = request.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
