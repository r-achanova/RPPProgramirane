using System;

namespace StatisticArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("count="+OptionsManager.CountLess100(arr));
            Console.WriteLine("max="+OptionsManager.MaxNum(arr));
            OptionsManager.PrintEvens(arr);
            Console.WriteLine("sumEvens="+OptionsManager.SumEvens(arr));
            Console.WriteLine("countEvens="+OptionsManager.CountEvens(arr));
            arr=OptionsManager.ReverseArr(arr);
            OptionsManager.PrintArr(arr);


            /*arr = OptionsManager.SortArr(arr);
            OptionsManager.PrintArr(arr);
            OptionsManager.PrintOdds(arr);
            OptionsManager.PrintArr(arr);*/



        }
    }
}
