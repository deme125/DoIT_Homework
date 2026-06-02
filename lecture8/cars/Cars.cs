using System;
using System.IO;

namespace cars
{
    public class Cars
    {
        private string brand;
        private string model;
        private int year;
        private double price;
        private string color;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    brand = value;
                }
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value;
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1950 && value <= DateTime.Now.Year + 1)
                {
                    year = value;
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    color = value;
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Brand} {Model}, {Year}, {Price}$, {Color}");
        }

        public static Cars FromFileLine(string line)
        {
            string[] parts = line.Split(',');

            return new Cars
            {
                Brand = parts[0],
                Model = parts[1],
                Year = int.Parse(parts[2]),
                Price = double.Parse(parts[3]),
                Color = parts[4]
            };
        }

        public static void ReadAndPrintFromFile(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    Cars car = FromFileLine(line);
                    car.PrintInfo();
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public void ApplyDiscount(double percent)
        {
            if (percent > 0 && percent < 100)
            {
                price -= price * percent / 100;
            }
        }

        public void IncreasePrice(double amount)
        {
            if (amount > 0)
            {
                price += amount;
            }
        }

        public int GetCarAge()
        {
            return DateTime.Now.Year - Year;
        }

        public bool IsExpensive()
        {
            return price > 50000;
        }
    }
}