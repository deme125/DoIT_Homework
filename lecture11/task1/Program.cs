namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 2, 3, 4, 5, 6 };
            ArrayClass arr = new ArrayClass(nums1);

            arr.ShowEven();
            arr.ShowOdd();
            Console.WriteLine($"there are { arr.CountDistinct()} uniqe numbers");
            int randomNumber = 1;
            Console.WriteLine($"there are {arr.EqualToValue(randomNumber)} numbers that are equal to {randomNumber}");

            Console.ReadKey();

        }
    }
}
