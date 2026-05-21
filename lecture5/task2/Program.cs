namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, -4, 8, 11, 1, -1, 6 };
            Console.WriteLine("write your number");
            bool validNum = int.TryParse(Console.ReadLine(), out int targetSum);

            if (validNum)
            {
                int counter = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == targetSum)
                        {
                            counter++;
                        }
                    }
                }
                int[,] resultArray = new int[counter, 2];
                int resultIndex = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == targetSum)
                        {
                            resultArray[resultIndex, 0] = nums[i];
                            resultArray[resultIndex, 1] = nums[j];
                            resultIndex++;
                        }
                    }
                }
                for (int i = 0; i < counter;  i++)
                {
                    Console.Write($"[{resultArray[i,0]}, {resultArray[i, 1]}] ");
                }

                Console.ReadKey();
            }
        }
    }
}
