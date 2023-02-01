using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticArray
{
   public static class OptionsManager
    {
        public static int CountLess100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }
        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }
        public static int CountEvens(int[] arr)
        {
            return arr.Count(x => x%2==0);
        }
        public static int SumEvens(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).Sum(); ;
        }

        public static int[] ReverseArr(int[] arr)
        {
            return arr.Reverse().ToArray();
        }

        public static void PrintArr(int[]arr)
        {
            Console.WriteLine(string.Join(", ",arr));
        }

        public static int[] SortArr(int[] arr)
        {
            return arr.OrderBy(x => x).ToArray();
        }

        public static void PrintEvens(int[] arr)
        {
            int[] result = arr.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ", result));

        }

        public static void PrintOdds(int[] arr)
        {
            int[] result = arr.Where(x => x % 2 == 1).ToArray();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
