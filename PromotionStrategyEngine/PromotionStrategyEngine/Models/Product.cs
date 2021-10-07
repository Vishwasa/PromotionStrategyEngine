namespace PromotionStrategyEngine.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public Product(string _ProductName, double _Price)
        {
            ProductName = _ProductName;
            Price = _Price;
        }
    }
}