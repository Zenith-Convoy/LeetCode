using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();
            foreach(int i in twoSum.main(new int[] { 3, 3}, 6))
            {
                Console.WriteLine(i.ToString());
            }
           
        }
        
    }
}
