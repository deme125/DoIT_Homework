namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {-1,2,6,-100,100};
            int max = nums[0];
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if(max < nums[i])
                {
                    max = nums[i];
                }
                if(min > nums[i])
                {
                    min = nums[i];
                }
            }
            Console.WriteLine($"min is: {min}\nmax is: {max}");
            
            Console.ReadLine();
        }
    }
}
