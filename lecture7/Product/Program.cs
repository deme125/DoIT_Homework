namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.Name = "Laptop";
            product1.Description = "Gaming Laptop";
            product1.Price = 2500;
            product1.Quantity = 5;
            product1.Brand = "Asus";
            product1.Category = "Electronics";
            product1.Rating = 4.8;
            product1.IsAvailable = true;
            product1.DiscountPercent = 10;

            product1.AddStock(3);
            product1.PrintInfo();

            Console.WriteLine("Final Price: " + product1.FinalPrice());



            Console.ReadKey();
        }
    }
}
