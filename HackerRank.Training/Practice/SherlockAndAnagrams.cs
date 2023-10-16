using System;
using System.Collections;
using System.Linq;

namespace HackerRank.Training.Practice
{
    public static class SherlockAndAnagrams
    {
        public static int Solution(string input)
        {
            int level = 0;
            int result = 0;
            Hashtable table = new Hashtable();

            // Nested loop to get all the combinations of substrings in the input
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - level; j++)
                {
                    // Get the characters of the substring for each combination
                    char[] characters = input.Substring(j, level + 1).ToArray();
                    // Sort to compare the string with others with the exact same content
                    Array.Sort(characters);
                    // Create the string for the characters
                    string word = new string(characters);

                    if (!table.ContainsKey(word))
                        table.Add(word, 0);

                    // Count the times the string is repeated
                    table[word] = (int)table[word] + 1;
                }

                // This keep track of the length of substrings
                level++;
            }

            foreach (var key in table.Keys)
            {
                int n = (int)table[key];

                if (n > 1)
                    // Calculate the combinations for each string repeated
                    result += (n - 1) * n / 2;
            }

            return result;
        }
    }
}
