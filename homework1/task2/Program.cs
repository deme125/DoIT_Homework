namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("პირველი რიცხვი: ");
            string strNum1 = Console.ReadLine();

            Console.WriteLine("მეორე რიცხვი: ");
            string strNum2 = Console.ReadLine();

            Console.WriteLine("მესამე რიცხვი: ");
            string strNum3 = Console.ReadLine();

            int num1 = int.Parse(strNum1);
            int num2 = int.Parse(strNum2);
            int num3 = int.Parse(strNum3);

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"ყველაზე დიდი რიცხვია: {num1}");
                Console.ReadLine();
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"ყველაზე დიდი რიცხვია: {num2}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"ყველაზე დიდი რიცხვია: {num3}");
                Console.ReadLine();
            }
        }
    }
}
