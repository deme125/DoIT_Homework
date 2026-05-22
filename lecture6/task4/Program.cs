namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] chars = ["abc", "def", "ghi"];
            for(int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars[i].Length; j++)
                {
                    Console.Write($"{chars[i][j]} ");
                }
            }
            Console.ReadLine();
        }
    }
}
