namespace Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public double Rating { get; set; }
        public bool IsAvailable { get; set; }
        public double DiscountPercent { get; set; }
        public string Brand { get; set; }


        public double FinalPrice()
        {
            double discountedPrice = Price - (Price * DiscountPercent / 100);
            return discountedPrice;
        }

        public void AddStock(int amount)
        {
            Quantity += amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"product: {Name}");
            Console.WriteLine($"price: {Price}");
            Console.WriteLine($"discount: {DiscountPercent} %");
            Console.WriteLine($"final price: {FinalPrice()}");
            Console.WriteLine($"quantity: {Quantity}");
            Console.WriteLine($"available: {IsAvailable}");
        }

    }
}