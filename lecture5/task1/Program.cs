namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            int[] arrBoth = new int[arr1.Length+arr2.Length];

            Console.WriteLine(arrBoth.Length);

            for (int i = 0; i < arrBoth.Length;i++)
            {
                if (arr1.Length > i)
                {
                    arrBoth[i] = arr1[i];
                }
                else
                {
                    arrBoth[i] = arr2[i-arr1.Length];
                }
            }
            for(int i = 0; i < arrBoth.Length; i++)
            {
                Console.Write(arrBoth[i]);
            }
            
            Console.ReadKey();
        }
    }
}
