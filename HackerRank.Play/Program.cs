using System;
using HackerRank.Training.Practice;

namespace HackerRank.Play
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] q = { 1, 2, 5, 3, 7, 8, 6, 4 };
            string result = MinimumBribes.Solution(q);

            Console.WriteLine(result);
        }
    }
}
