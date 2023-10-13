namespace HackerRank.Training.Practice
{
    public static class MinimumBribes
    {
        public static string Solution(List<int> queue)
        {
            int result = 0;
            int n = queue.Count;
            // The person will be holding his initial position
            int person,
            // This position will point where are we placed in the queue
            position,
            // This min variable will save the lowest original position found in the queue
            min = n;
            
            //1 2 5 3 7 8 6 4
            for (int i = n - 1; i >= 0; i--)
            {
                person = queue[i];
                position = i + 1;

                // If the person was moved forward to the current position
                if (person > position) {
                    // Then we count the number of positions that the person was moved
                    result += person - position;
                    
                    // If the person was moved forward more than 2 positions
                    if (person - position > 2) {
                        // Then is chaotic
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                } else {
                    // If we find a lower ticket
                    if (min > person)
                    {
                        // Not aditional bribes
                        // but set the min to the new lowest found
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
            
            Console.WriteLine(result);
        }
    }
}
