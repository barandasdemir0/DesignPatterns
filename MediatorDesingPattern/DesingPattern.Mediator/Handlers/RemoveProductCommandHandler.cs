using DesingPattern.Mediator.Commands;
using DesingPattern.Mediator.DAL;
using MediatR;

namespace DesingPattern.Mediator.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
             _context.Remove(values);
            _context.SaveChangesAsync();
        }
    }
}
