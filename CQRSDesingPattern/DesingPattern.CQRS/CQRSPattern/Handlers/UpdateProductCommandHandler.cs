using DesingPattern.CQRS.CQRSPattern.Commands;
using DesingPattern.CQRS.Dal;

namespace DesingPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }


        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Name = command.Name;
            values.Status = true;
            values.ProductID = command.ProductID;
            values.stock = command.stock;
            values.Description = command.Description;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}
