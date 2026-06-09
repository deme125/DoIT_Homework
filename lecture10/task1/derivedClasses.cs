using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Violin : MusicalInstrument
    {
        public Violin(string brand, decimal price) : base(brand, price)
        {
            InstrumentName = Instrument.Violin;
            Type = InstrumentType.String;
        }
        public override void Play()
        {
            Console.WriteLine("playing the Violin!");
        }

    }
    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string brand, decimal price) : base(brand, price)
        {
            InstrumentName = Instrument.Ukulele;
            Type = InstrumentType.String;
        }

        public override void Play()
        {
            Console.WriteLine("playing the Ukulele!");
        }

    }
    public class Cello : MusicalInstrument
    {
        public Cello(string brand, decimal price) : base(brand, price)
        {
            InstrumentName = Instrument.Cello;
            Type = InstrumentType.String;
        }
        public override void Play()
        {
            Console.WriteLine("playing the Cello!");
        }

    }
    public class Trombone : MusicalInstrument
    {
        public Trombone(string brand, decimal price) : base(brand, price)
        {
            InstrumentName = Instrument.Trombone;
            Type = InstrumentType.Brass;
        }
        public override void Play()
        {
            Console.WriteLine("playing the Trombone!");
        }

    }
}
