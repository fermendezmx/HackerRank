using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Training.Practice
{
    public static class HourglassSum
    {
        public static int Solution(int[][] arr)
        {
            List<int> result = new List<int>();

            // Loop over the 2D array to get the sum of every hourglass
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // Get the hourglass sum for the current position
                    //            A             B              C
                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                    //       D
                    arr[i + 1][j + 1] +
                    //     E                F                  G
                    arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    result.Add(sum);
                }
            }

            // Get the maximum hourglass sum
            return result.Max();
        }
    }
}
