using System;
using HackerRank.Training.DataStructures;

namespace HackerRank.Play
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] m = { "two", "times", "three", "is", "not", "four" };
            string[] n = { "two", "times", "two", "is", "four" };
            string result = RansomNote.Solution(m, n);

            Console.WriteLine(result);
        }
    }
}
