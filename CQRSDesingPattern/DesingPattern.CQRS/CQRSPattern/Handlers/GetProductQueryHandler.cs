using DesingPattern.CQRS.CQRSPattern.Results;
using DesingPattern.CQRS.Dal;
using System.Collections.Generic;
using System.Linq;

namespace DesingPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ID = x.ProductID,
                ProductName = x.Name,
                Stock = x.stock,
                Price = x.Price
            }).ToList();
            return values;
        }
    }
}
