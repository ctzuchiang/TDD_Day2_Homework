using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public static class CashierService
    {
        public static int GetPurchasingPrice<TSource>(this IEnumerable<TSource> source, IEnumerable<TSource> product)
        {
            throw new NotImplementedException();
        }
    }

    public class Product
    {
        public string Name { get; set; }
    }
}
