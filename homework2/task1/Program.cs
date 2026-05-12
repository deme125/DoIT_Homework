namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "admin";

            string password = "1234";



            Console.Write("enter username: ");

            string userNameInp = Console.ReadLine();


            Console.Write("enter password: ");

            string userPassInp = Console.ReadLine();



            if (userName == userNameInp && password == userPassInp)

            {

                Console.WriteLine("Welcome!");
                Console.ReadLine();

            }
            else
            {

                Console.WriteLine("acsses denied");
                Console.ReadLine();
            }
        }
    }
}
