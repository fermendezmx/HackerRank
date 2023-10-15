using HackerRank.Training.Practice;
using Xunit;

namespace HackerRank.UnitTest.Practice
{
    public class TArrayManipulation
    {
        [Fact]
        public void Test1()
        {
            int n = 10;
            int[][] queries = { new int[] { 1, 5, 3 }, new int[] { 4, 8, 7 }, new int[] { 6, 9, 1 } };
            long expected = 10;
            long result = ArrayManipulation.Solution(n, queries);

            Assert.Equal(expected, result);
        }
    }
}
