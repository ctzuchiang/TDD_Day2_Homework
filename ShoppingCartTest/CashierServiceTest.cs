using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace ShoppingCartTest
{
    [TestClass]
    public class CashierServiceTest
    {
        [TestMethod]
        public void Purchase_HarryPotter_episode1_1_price_is_100()
        {
            //Arrange
            //當我到了收銀台
            var target = new CashierService();

            //Act
            //給收銀台 哈利波特 第 1 集 1 本
            var products = new List<Product>()
            {
                new Product(){Name = "HarryPotter_1",Count = 1}
            };

            var actual = target.GetPurchasingPrice(products);

            //Assert
            //結帳價格為 100 元
            Assert.AreEqual(actual, 100);
        }

        [TestMethod]
        public void Purchase_HarryPotter_episode1_1_and_episode2_1_price_is_190_after_5_percent_discount()
        {
            //Arrange
            //當我到了收銀台
            var target = new CashierService();

            //Act
            //給收銀台 哈利波特 第 1 集 1 本, 第 2 集 1 本
            var products = new List<Product>()
            {
                new Product(){Name = "HarryPotter_1",Count = 1},
                new Product(){Name = "HarryPotter_2",Count = 1}
            };

            var actual = target.GetPurchasingPrice(products);

            //Assert
            //結帳價格為 100 元
            Assert.AreEqual(actual, 190);
        }
    }
}
