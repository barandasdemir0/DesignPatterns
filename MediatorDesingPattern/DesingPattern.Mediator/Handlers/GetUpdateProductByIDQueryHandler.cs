using DesingPattern.Mediator.DAL;
using DesingPattern.Mediator.Queries;
using DesingPattern.Mediator.Results;
using MediatR;

namespace DesingPattern.Mediator.Handlers
{
    public class GetUpdateProductByIDQueryHandler : IRequestHandler<GetUpdateProductByIDQuery, UpdateProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetUpdateProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIDQueryResult> Handle(GetUpdateProductByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new UpdateProductByIDQueryResult
            {
                ProductID = values.ProductID,
                ProductCategory = values.ProductCategory,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock,
                ProductStockType = values.ProductStockType
            };
        }
    }
}
