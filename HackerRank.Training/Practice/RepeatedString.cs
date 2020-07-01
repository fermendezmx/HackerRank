namespace HackerRank.Training.Practice
{
    public static class RepeatedString
    {
        public static long Solution(string s, long n)
        {
            long result = 0;
            int A = 0;

            // Count how many 'a's are in the string
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    A++;
                }
            }

            // Gives a no decimal value
            long times = n / s.Length;
            // Here we get the residual
            long diff = n - (s.Length * times);
            // And calculate how many times should be an 'a'
            result = A * times;

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
