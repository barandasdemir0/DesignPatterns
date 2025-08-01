﻿namespace DesingPattern.Mediator.Results
{
    public class UpdateProductByIDQueryResult
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int ProductStock { get; set; }
        public string? ProductStockType { get; set; }
        public decimal ProductPrice { get; set; }
        public string? ProductCategory { get; set; }
    }
}
