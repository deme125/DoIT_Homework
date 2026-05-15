namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your number: ");
            Random r = new Random();
            int randomNum = r.Next(0, 10);
            int num = 0;
            bool validNum = false;
            while (true)
            {
                validNum = int.TryParse(Console.ReadLine(), out num);

                if (!validNum)
                {
                    Console.WriteLine($"invalid input");
                }
                else if (randomNum == num)
                {
                    Console.WriteLine("gilocav shen gamoicani");
                    break;
                }
                else
                {
                    Console.Write($"samwuxarod ver gamoicani tavidan scade: ");

                }
            }
            


                Console.ReadKey();
        }
    }
}
