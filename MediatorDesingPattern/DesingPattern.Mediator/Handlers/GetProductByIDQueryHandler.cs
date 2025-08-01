using DesingPattern.Mediator.DAL;
using DesingPattern.Mediator.Queries;
using DesingPattern.Mediator.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesingPattern.Mediator.Handlers
{
    public class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, GetProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIDQueryResult> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductByIDQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductStock = values.ProductStock
            };
        }
    }
}
