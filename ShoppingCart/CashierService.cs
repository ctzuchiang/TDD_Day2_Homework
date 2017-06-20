using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class CashierService
    {
        private readonly Dictionary<int, decimal> _DiscountProduct = new Dictionary<int, decimal>
        {
            {1, 1},
            {2, 0.95m},
            {3, 0.9m},
            {4, 0.8m},
            {5, 0.75m}
        };

        private readonly decimal _BookPrice = 100;

        public decimal GetPurchasingPrice(List<Product> products)
        {
            var price = 0m;
            while (ProductSet(products) > 0)
            {
                price += ProductSet(products) * _BookPrice * _DiscountProduct[ProductSet(products)];
                products.ForEach(p => { p.Count--; });
            }
            return price;
        }

        private int ProductSet(List<Product> products)
        {
            return products.Count(p => p.Count > 0);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Episode { get; set; }
        public int Count { get; set; }
    }
}