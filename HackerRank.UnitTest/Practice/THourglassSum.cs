using HackerRank.Training.Practice;
using Xunit;

namespace HackerRank.UnitTest.Practice
{
    public class THourglassSum
    {
        [Fact]
        public void Test1()
        {
            int[][] input = new int[6][];
            input[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            input[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            input[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            input[3] = new int[] { 0, 0, 2, 4, 4, 0 };
            input[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            input[5] = new int[] { 0, 0, 1, 2, 4, 0 };
            long expected = 19;
            long result = HourglassSum.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[][] input = new int[6][];
            input[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            input[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            input[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            input[3] = new int[] { 0, 9, 2, -4, -4, 0 };
            input[4] = new int[] { 0, 0, 0, -2, 0, 0 };
            input[5] = new int[] { 0, 0, -1, -2, -4, 0 };
            long expected = 13;
            long result = HourglassSum.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int[][] input = new int[6][];
            input[0] = new int[] { -9, -9,  -9, 1, 1, 1 };
            input[1] = new int[] { 0, -9, 0, 4, 3, 2 };
            input[2] = new int[] { -9, -9, -9, 1, 2, 3 };
            input[3] = new int[] { 0, 0, 8, 6, 6, 0 };
            input[4] = new int[] { 0, 0, 0, -2, 0, 0 };
            input[5] = new int[] { 0, 0, 1, 2, 4, 0 };
            long expected = 28;
            long result = HourglassSum.Solution(input);

            Assert.Equal(expected, result);
        }
    }
}
