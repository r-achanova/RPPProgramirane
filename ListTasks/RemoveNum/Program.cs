using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var last = nums[nums.Count - 1];
            //nums.Remove(last);
            nums.RemoveAll(x => x == last);
            Console.WriteLine(string.Join(" ", nums));

        } 
    }
}
