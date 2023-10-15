using System;
using System.Collections.Generic;

namespace HackerRank.Training.Practice
{
    public static class ArrayManipulation
    {
        public static long Solution(int n, int[][] queries)
        {
            long max = 0;
            long sum = 0;
            long[] operations = new long[n + 1];

            // In this case, we can use the prefix sum technique 
            // to determine the MAX value in the resultant array

            // Given an input:
            // a b k
            // 1 5 3 
            // 4 8 7
            // 6 9 1

            // We create the array to compute the prefix sum technique:    
            foreach (var query in queries)
            {
                // a = query[0], k = query[2]
                operations[query[0] - 1] += query[2];
                // b + 1 = query[1], k = query[2]
                operations[query[1]] -= query[2];
            }

            // The array we get is:
            // [ 3, 0, 0, 7, 0, -2, 0, 0, -7, -1 ]
            // And with the prefix sum technique it will be:
            // [ 3, 3, 3, 10, 10, 8, 8, 8, 1, 0 ]

            // So, using the prefix sum technique over the array we look for the MAX value
            foreach (var value in operations)
            {
                sum += value;
                max = Math.Max(sum, max);
            }

            return max;
        }
    }
}
