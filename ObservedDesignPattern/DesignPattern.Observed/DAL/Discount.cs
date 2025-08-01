﻿using Microsoft.AspNetCore.Identity;

namespace DesignPattern.Observed.DAL
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string? DiscountCode { get; set; }
        public int DiscountAmount { get; set; }
        public bool DiscountCodeStatus { get; set; }
    }
}
