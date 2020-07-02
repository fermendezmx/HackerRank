using System.Linq;

namespace HackerRank.Training.Practice
{
    public static class EqualizeArray
    {
        public static int Solution(int[] arr)
        {
            int result = 0;
            int counter = 0;
            int removed = 0;
            // Get the list of individual numbers availables in array
            int[] numbers = arr.Distinct().ToArray();

            // Look over the list of individual numbers in array
            for (int i = 0; i < numbers.Length; i++)
            {
                // Count how many times is repeated the current number in the original array
                counter = arr.Count(x => x == numbers[i]);
                // The rest of the numbers in the original array can be removed
                removed = arr.Length - counter;

                // Check if the current value of 'removed' is lower than a previous one
                if (result == 0 || removed < result)
                {
                    // Then update the result to a lower number of removed items:
                    // This set the minimum number of elements to delete
                    result = removed;
                }
            }

            return result;
        }
    }
}
