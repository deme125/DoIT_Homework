namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] passcode = new int[10];
            for (int i = 0; i < passcode.Length; i++)
            {
                int num = r.Next(1000, 9999);
                passcode[i] = num;
            }
            for (int i = 0; i < passcode.Length; i++)
            {
                Console.WriteLine(passcode[i]);
            }
            Console.WriteLine("write your passcode: ");
            bool validGuess = int.TryParse(Console.ReadLine(), out int guess);
            if (validGuess)
            {
                bool check = false;
                for (int i = 0; i < passcode.Length; i++)
                {
                    if (guess == passcode[i])
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
            Console.ReadLine();
        }
    }
}
