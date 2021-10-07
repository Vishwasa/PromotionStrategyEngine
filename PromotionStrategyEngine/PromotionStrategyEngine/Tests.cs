using PromotionStrategyEngine.DiscountStrategyPattern;
using PromotionStrategyEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionStrategyEngine
{
    class Tests
    {
        public bool TestScenario1()
        {
            Cart cart = new Cart();
            Product a = new Product("A", 50);
            Product b = new Product("B", 30);
            Product c = new Product("C", 20);
            cart.AddProduct(a).AddProduct(b).AddProduct(c);
            DiscountStrategy1 strategy = new DiscountStrategy1();
            Invoice invoice = new Invoice(strategy);
            return invoice.getDiscountedPrice(cart) == 0;
        }
    }
}
