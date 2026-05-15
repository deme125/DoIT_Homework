namespace task3
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
            int sum = 0;
            for (int i = 0; i <= num; i += 2)
            {
                sum += i;
            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
