using DesingPattern.Mediator.Commands;
using DesingPattern.Mediator.DAL;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesingPattern.Mediator.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.ProductID);
            value.ProductName = request.ProductName;
            value.ProductPrice = request.ProductPrice;
            value.ProductStockType = request.ProductStockType;
            value.ProductStock = request.ProductStock;
            value.ProductCategory = request.ProductCategory;
            await _context.SaveChangesAsync();
        }
    }
}
