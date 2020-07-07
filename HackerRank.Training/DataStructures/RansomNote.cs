using System;
using System.Collections;

namespace HackerRank.Training.DataStructures
{
    public static class RansomNote
    {
        public static string Solution(string[] magazine, string[] note)
        {
            Hashtable magFrequency = GetFrequency(magazine);
            Hashtable noteFrequency = GetFrequency(note);
            return HasEnoughtWords(magFrequency, noteFrequency);
        }

        private static Hashtable GetFrequency(string[] words)
        {
            Hashtable frequencies = new Hashtable();

            foreach (var word in words)
            {
                if (!frequencies.ContainsKey(word))
                {
                    frequencies.Add(word, 0);
                }

                frequencies[word] = (int)frequencies[word] + 1;
            }

            return frequencies;
        }

        private static string HasEnoughtWords(Hashtable magFrequency, Hashtable noteFrequency)
        {
            foreach (var word in noteFrequency.Keys)
            {
                if (!magFrequency.ContainsKey(word) || (int)magFrequency[word] < (int)noteFrequency[word])
                {
                    return "No";
                }
            }

            return "Yes";
        }
    }
}
