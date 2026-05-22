using System.Net.NetworkInformation;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[][] points = [[7,8,7],[10,9,8,9],[5,10,6,7,8,7]];

            for(int i = 0; i < points.Length; i++)
            {
                float avarage = 0;
                for (int j = 0; j < points[i].Length; j++)
                {
                    avarage += points[i][j] / points[i].Length;
                }
                Console.WriteLine(avarage);
            }
            Console.ReadKey();
        }
    }
}
