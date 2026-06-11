using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class ArrayClass : IOutput2, ICalc2
    {
        private int[] nums;

        public ArrayClass(int[] nums)
        {
            Nums = nums;
        }

        public int[] Nums
        {
            get { return nums; }
            set
            {
                if(value != null && value.Length > 0)
                {
                    nums = value;
                }
            }
        }

        public int CountDistinct()
        {
            int count = 0;
            bool hasDuplicates = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        hasDuplicates = true;
                    }
                }
                if(hasDuplicates == false)
                {
                    count++;
                }
            }
            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
        

        public void ShowEven()
        {
            Console.Write("Evens are: ");
            foreach (var item in nums)
            {
                if(item%2 == 0)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("Odds are: ");
            foreach (var item in nums)
            {
                if (item % 2 != 0)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();
        }
    }
}
