namespace HackerRank.Training.Practice
{
    public static class MinimumBribes
    {
        public static string Solution(int[] q)
        {
            int result = 0;
            int n = q.Length;
            // The person will be holding his initial position
            int person,
            // This position will point where are we placed in the queue
            position,
            // This min variable will save the lowest original position found in the queue
            min = n;
            //1 2 5 3 7 8 6 4
            for (int i = n - 1; i >= 0; i--)
            {
                person = q[i];
                position = i + 1;

                // If the person was moved forward more than 3 positions
                if (person - i > 3)
                {
                    // Then is chaotic
                    return "Too chaotic";
                }
                // If the person was moved forward to the current position
                else if (person > position)
                {
                    // Then we count the number of positions that the person was moved
                    result += person - position;
                }
                else
                {
                    // If we find a lowest ticket
                    if (min > person)
                    {
                        // Not aditional bribes
                        // But set the min to the new lowest found
                        min = person;
                    }
                    // If the person was moved
                    else if (person != min)
                    {
                        // Add the bribe to the count
                        result++;
                    }
                }
            }

            return $"{result}";
        }
    }
}
