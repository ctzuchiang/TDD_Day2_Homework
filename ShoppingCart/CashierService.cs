using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class CashierService
    {
        public decimal GetPurchasingPrice(List<Product> products)
        {
            return products.Select(x =>
            {
                if (x.Name == "HarryPotter_1")
                    return x.Count*100;
                return 0;
            }).Sum();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
