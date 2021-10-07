using PromotionStrategyEngine.DiscountStrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionStrategyEngine.Models
{
    class Invoice
    {
        private IDiscountStrategy strategy;
        public Invoice(IDiscountStrategy _strategy)
        {
            strategy = _strategy;
        }
        public double getDiscountedPrice(Cart cart)
        {
            return strategy.CalculateDiscountedPrice(cart);
        }
    }
}
