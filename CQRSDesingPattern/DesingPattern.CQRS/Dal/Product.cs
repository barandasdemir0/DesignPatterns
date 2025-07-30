namespace DesingPattern.CQRS.Dal
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int stock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
