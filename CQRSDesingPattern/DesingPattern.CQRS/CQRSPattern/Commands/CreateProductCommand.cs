namespace DesingPattern.CQRS.CQRSPattern.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public int stock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
