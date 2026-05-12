namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("chaweret tqveni asaki: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("tqven xart bavshvi");
                Console.ReadLine();
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("tqven xart tineijeri");
                Console.ReadLine();
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("tqven xart zrdasruli");
                Console.ReadLine();
            }
            else if (age >= 65 && age <= 255)
            {
                Console.WriteLine("tqven xart pensioneri");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("tqveni sheyvanili asaki ar aris swori");
                Console.ReadLine();
            }
        }
    }
}
