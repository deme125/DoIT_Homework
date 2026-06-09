using System;
using System.Security.Cryptography.X509Certificates;

namespace task1
{
    public enum InstrumentType
    {
        String,
        Keyboard,
        Wind,
        Brass,
        Percussion
    }

    public enum Instrument
    {
        Violin,
        Ukulele,
        Cello,
        Trombone
    }

    public abstract class MusicalInstrument
    {
        private string brand;
        private decimal price;

        public DateTime CreatedAt { get; private set; }
        public InstrumentType Type { get; set; }
        public Instrument InstrumentName { get; set; }


        public string Brand
        {
            get { return brand; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    brand = value.Trim();
                }
            }
        }

        public decimal Price
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




        public MusicalInstrument(string brand, decimal price)
        {
            Brand = brand;
            Price = price;
            CreatedAt = DateTime.Now;
        }

        public abstract void Play();

        public void Show()
        {
            Console.WriteLine($"Instrument's name is: {InstrumentName}");
        }
        public void Desc()
        {
            Console.WriteLine($"Instrument's Type is: {Type}");
        }
        public void History()
        {
            Console.WriteLine($"creation of this Instrument is{CreatedAt}");
        }

    }
}




