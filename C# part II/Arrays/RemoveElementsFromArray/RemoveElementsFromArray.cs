using System;
using System.Collections.Generic;

class LongestIncreasingSequence
{
    static void Main()
    {
	
	int n = int.Parse(Console.ReadLine());
        List<int> nums = new List<int>();
        for (int i = 0; i < n; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }
            int[] LIS = new int[nums.Count];
            for (int i = 0; i < nums.Count; i++)
            {
                LIS[i] = 1;
            }

            int maxCount = 1;
            for (int i = 1; i < nums.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] >= nums[j] && LIS[i] <= LIS[j] + 1)
                    {
                        LIS[i] = LIS[j] + 1;
                        if (maxCount < LIS[i])
                        {
                            maxCount = LIS[i];
                        }
                    }
                }
            }
            int result = n - maxCount;
            Console.WriteLine(result);
     }
}