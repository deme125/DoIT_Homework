namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Violin v = new Violin("Yamaha", 500);
                Ukulele u = new Ukulele("Kala", 300);
                Cello c = new Cello("Stentor", 800);
                Trombone t = new Trombone("Bach", 1000);

                MusicalInstrument[] instruments = { v, u, c, t };

                foreach (var instrument in instruments)
                {
                    instrument.Show();
                    instrument.Desc();
                    instrument.History();
                    instrument.Play();

                    Console.ReadKey();
                }
        }
    }
}
