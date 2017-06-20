using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class CashierService
    {
        public decimal GetPurchasingPrice(List<Product> products)
        {
            throw new NotImplementedException();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
