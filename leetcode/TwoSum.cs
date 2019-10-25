using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class TwoSum
    {
        public int[] main(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int e = i + 1; e < nums.Length; e++)
                {
                    if (nums[i] + nums[e] == target)
                    {
                        return new int[2] { i, e };
                    }
                }
            }
            return new int[2] { -1, -1 };
        }
    }
}
