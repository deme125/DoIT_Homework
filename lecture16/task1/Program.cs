

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 5, 12, 3, 12, 8, 20 };
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                { "A", 10 },
                { "B", 50 },
                { "C", 5 }
            };

            // 1. Where
            var resWhereList = Algorithms.Where(list, x => x > 10);
            var resWhereDict = Algorithms.Where(dict, x => x.Value > 10);

            // 2. OrderBy
            var resOrderList = Algorithms.OrderBy(list, x => x);
            var resOrderDict = Algorithms.OrderBy(dict, x => x.Value);

            // 3. First & FirstOrDefault
            int resFirst = Algorithms.First(list, x => x % 2 == 0);
            var resFirstDefault = Algorithms.FirstOrDefault(dict, x => x.Value > 100);

            // 4. Single
            int resSingle = Algorithms.Single(list, x => x == 5);

            // 5. Any & All
            bool resAny = Algorithms.Any(list, x => x < 0);
            bool resAll = Algorithms.All(dict, x => x.Value > 1);

            // 6. Count
            int resCount1 = Algorithms.Count(list, x => x < 15);
            int resCount2 = Algorithms.Count(dict, x => x.Value < 20);

            // 7. Distinct
            var resDistinct = Algorithms.Distinct(list);

            // Print Results
            Console.WriteLine("Where List: " + string.Join(", ", resWhereList));
            Console.WriteLine("Where Dict Count: " + Algorithms.Count(resWhereDict, x => x.Value <= int.MaxValue));
            Console.WriteLine("Order List: " + string.Join(", ", resOrderList));
            Console.WriteLine("First Match: " + resFirst);
            Console.WriteLine("FirstOrDef Missing Key: " + (resFirstDefault.Key ?? "null"));
            Console.WriteLine("Single Match: " + resSingle);
            Console.WriteLine("Any Negative: " + resAny);
            Console.WriteLine("All Greater Than 1: " + resAll);
            Console.WriteLine("Total Count: " + resCount1);
            Console.WriteLine("Filtered Count: " + resCount2);
            Console.WriteLine("Distinct List: " + string.Join(", ", resDistinct));

            Console.ReadKey();
        }
    }
}