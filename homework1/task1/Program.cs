namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("რამდენი წლის ხარ? ");
            string strAge = Console.ReadLine();
            byte age = byte.Parse(strAge);

            if (age >= 18)
            {
                Console.WriteLine("გილოცავ! ხმის მიცემის უფლება გაქვთ.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("სამწუხაროდ ხმის მიცემის უფლება არ გაქვთ.");
                Console.ReadLine();
            }
        }
    }
}
