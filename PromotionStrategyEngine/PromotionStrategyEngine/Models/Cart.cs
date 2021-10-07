using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionStrategyEngine.Models
{
    class Cart
    {
        public Dictionary<Product, int> productMap { get; set; }
        public void AddProduct(Product _product)
        {
            if (productMap.ContainsKey(_product))
            {
                productMap[_product]++;
            }
            else
            {
                productMap.Add(_product, 1);

            }
        }
        public void RemoveProduct(Product _product)
        {
            if (productMap.ContainsKey(_product))
            {
                productMap[_product]--;
            }
            else
            {
                throw new Exception("cant remove product as there are no products of mentioned type");
            }
        }
    }
}
