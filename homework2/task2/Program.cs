namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sheiyvanet pirveli ricxvi: ");
            int num1;
            int.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("sheiyvanet tqveni operatori: ");
            string op = Console.ReadLine();

            Console.WriteLine("sheiyvanet meore ricxvi: ");
            int num2;
            int.TryParse(Console.ReadLine(), out num2);

            switch (op){
                case "+":
                    Console.WriteLine(num1 + num2);
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    Console.ReadLine();
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    Console.ReadLine();
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    Console.ReadLine();
                    break;




                
            }
        }
    }
}
