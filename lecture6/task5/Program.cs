namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emails = ["deme@gmail.com", "demetre@gmail.com", "dimitri@gmail.com", "d_Sheklashviligmail.com"];
            for (int i = 0; i < emails.Length; i++)
            {
                bool check = false;
                for(int j = 0; j < emails[i].Length; j++)
                {
                    if (emails[i][j] == '@')
                    {
                        Console.WriteLine($"{emails[i]} is correct");
                        check = true;
                    }
                    
                    
                }
                if(check == false)
                {
                    Console.WriteLine($"{emails[i]} is not valid");
                }
            }
            Console.ReadLine();
        }
    }
}
