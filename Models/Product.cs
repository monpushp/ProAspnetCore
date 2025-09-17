namespace ProAspnetCore.Models
{
    public class Product
    {

        public required string Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProducts()
        {
            Product kayak = new()
            {
                Name = "Kayak",
                Price = 275M
            };

            Product lifeJacket = new()
            {
                Name = "LifeJacker",
                Price = 48.95M
            };

            return [kayak, lifeJacket, null];
        }
    }
}
