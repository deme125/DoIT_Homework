namespace task2
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
            for (int i = 0; i < num; i++)
            {
                for (int j = num - i; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
