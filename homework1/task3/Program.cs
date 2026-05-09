namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number: ");
            string strNum1 = Console.ReadLine();

            Console.WriteLine("first number: ");
            string strNum2 = Console.ReadLine();


            int num1 = int.Parse(strNum1);
            int num2 = int.Parse(strNum2);

            if (num1 == num2)
            {
                Console.WriteLine((num1 + num2) * 2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num1 + num2);
                Console.ReadLine();
            }
        }
    }
}