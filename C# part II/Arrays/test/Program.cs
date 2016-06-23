using System;
using System.Collections.Generic;

class RemoveFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int currentCount = 1;
        int minCount = n;
        int bigCount = 0;
        int current = 0;
        bool isBreak = false;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }


        for (int k = 0; k < n - 1; k++)
        {
            current = k;
            for (int i = k; i < n - 1; i++)
            {
                //check if the  CURRENT element from the selected subsequence is smaller, than the i+1 -th element from the sequence
                if (arr[current] <= arr[i + 1])
                {
                    //check in the  elements after the i+1 th element from the subsequence 
                    // if there are any numbers, that are smaller than the i+1 th element, but bigger, than the current element from the selected subsequence
                    // than continue the iteration without counting the i+1 th element, 
                    //else if the next elements are equal or bigger than the i+1 th element, count the i+1-th element and continie the iteration
                    for (int j = i + 2; j < n; j++)
                    {
                        if (arr[i + 1] > arr[j] && arr[current] <= arr[j])
                        {
                            isBreak = true;

                            break;
                        }
                        else if (arr[i + 1] <= arr[j])
                        {
                            break;
                        }

                    }
                    if (isBreak)
                    {
                        isBreak = false;
                        continue;

                    }
                    currentCount++;
                    current = i + 1;
                }
            }


            if (currentCount > bigCount)
            {
                bigCount = currentCount;
            }
            currentCount = 1;
        }

        Console.WriteLine(bigCount);
        Console.ReadKey();
    }
}