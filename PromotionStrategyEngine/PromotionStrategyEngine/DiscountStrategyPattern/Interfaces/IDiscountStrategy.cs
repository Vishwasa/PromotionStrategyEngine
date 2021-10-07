using PromotionStrategyEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionStrategyEngine.DiscountStrategyPattern.Interfaces
{
    interface IDiscountStrategy
    {
        double CalculateDiscountedPrice(Cart cart);
    }
}
