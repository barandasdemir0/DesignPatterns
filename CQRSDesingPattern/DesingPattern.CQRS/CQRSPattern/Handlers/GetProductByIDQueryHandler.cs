using DesingPattern.CQRS.CQRSPattern.Queries;
using DesingPattern.CQRS.CQRSPattern.Results;
using DesingPattern.CQRS.Dal;


namespace DesingPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIdQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                stock = values.stock
            };
        }
    }
}
