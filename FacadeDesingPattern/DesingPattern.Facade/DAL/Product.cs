namespace DesingPattern.Facade.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public decimal ProductPrice { get; set; }
        public string? ProductCategory { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
