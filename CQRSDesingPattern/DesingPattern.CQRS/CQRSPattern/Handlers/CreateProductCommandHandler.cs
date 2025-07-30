using DesingPattern.CQRS.CQRSPattern.Commands;
using DesingPattern.CQRS.Dal;

namespace DesingPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Description = command.Description,
                Name = command.Name,
                Price = command.Price,
                Status = true,
                stock = command.stock,
            });

            _context.SaveChanges();
        }
    }
}
