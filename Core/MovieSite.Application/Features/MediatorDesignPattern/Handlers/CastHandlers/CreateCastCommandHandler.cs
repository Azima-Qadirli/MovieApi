using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Commands.CastCommand;
using MovieSite.Domain.Entities;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieSiteDbContext _context;

        public CreateCastCommandHandler(MovieSiteDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            _context.Casts.Add(new Cast
            {
                Biography = request.Biography,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Overview = request.Overview,
                Surname = request.Surname,
                Title = request.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
