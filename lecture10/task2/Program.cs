namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            president p = new president("Dimitri","Sheklashvili",20000);
            Security s = new Security("Giorgi", "Sheklashvili", 15000);
            Manager m = new Manager("Luka", "Sheklashvili", 10000);
            Engineer e = new Engineer("Aleqsandre", "Sheklashvili", 30000);

            Worker[] workers = { p, s, m, e };

            foreach (var item in workers)
            {
                item.PrintInfo();
            }
            Console.ReadKey();
        }
    }
}
