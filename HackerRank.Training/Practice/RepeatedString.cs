namespace HackerRank.Training.Practice
{
    public static class RepeatedString
    {
        public static long Solution(string s, long n)
        {
            long result = 0;
            int A = 0;

            // Count how many 'a's are in the given string 's'
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    A++;
                }
            }

            // Get the number of times that the given string 's' should
            // be placed in a new string of 'n' items
            long times = n / s.Length;
            // Calculate how many 'a's we had found until now
            result = A * times;
            // Given that 'times' may leave a residual
            // We check if there are some missing chars to fill a string of 'n' items
            long diff = n - (s.Length * times);

            // Then look for more 'a's in the end
            for (int i = 0; i < diff; i++)
            {
                if (s[i] == 'a')
                {
                    result++;
                }
            }

            return result;
        }
    }
}
