using System;

namespace cars
{
    class Program
    {
        static void Main()
        {
            string path = @"../../../carsData.txt";

            Cars.ReadAndPrintFromFile(path);

            Cars car = new Cars
            {
                Brand = "Mercedes",
                Model = "C200",
                Year = 2021,
                Price = 30000,
                Color = "Black"
            };

            car.PrintInfo();

            car.ApplyDiscount(10);
            car.PrintInfo();

            car.IncreasePrice(2000);
            car.PrintInfo();

            Console.WriteLine(car.GetCarAge());
            Console.WriteLine(car.IsExpensive());

            Cars.ReadAndPrintFromFile(path);

            Console.ReadKey();
        }
    }
}