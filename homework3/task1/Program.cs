namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your number: ");
            int num = 0;
            bool validNum = false;
            while (!validNum)
            {
                validNum = int.TryParse(Console.ReadLine(), out num);
                if (validNum == false)
                {
                    Console.Write("invalid input try again: ");
                }
            }

            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = { num* i}");
            }




            Console.ReadKey();
        }
    }
}
