using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Training.Practice
{
    public static class RotLeft
    {
        public static int[] Solution(int[] a, int d)
        {
            int position;
            int n = a.Length;
            int[] result = new int[n];

            // Look over the array to rotate every number
            for (int i = 0; i < n; i++)
            {
                // Calculate new position for current number
                position = i - d;

                // Fix position if it is lower than 0
                if (position < default(int))
                {
                    position = n + position;
                }

                // Assign number to the new position
                result[position] = a[i];
            }

            return result;
        }
    }
}
