using MediatR;
using MovieSite.Application.Features.MediatorDesignPattern.Commands.CastCommand;
using MovieSite.Persistence.Context;

namespace MovieSite.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class UpdateCastCommandHandleR : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieSiteDbContext _context;

        public UpdateCastCommandHandleR(MovieSiteDbContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Casts.FindAsync(request.CastId);
            value.Surname = request.Surname;
            value.ImageUrl = request.ImageUrl;
            value.Biography = request.Biography;
            value.Name = request.Name;
            value.Overview = request.Overview;
            value.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
