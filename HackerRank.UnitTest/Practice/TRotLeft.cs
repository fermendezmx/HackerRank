using HackerRank.Training.Practice;
using Xunit;

namespace HackerRank.UnitTest
{
    public class TRotLeft
    {
        [Fact]
        public void Test1()
        {
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] expected = { 5, 1, 2, 3, 4 };
            int[] result = RotLeft.Solution(a, d);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int d = 10;
            int[] a = { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 };
            int[] expected = { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 };
            int[] result = RotLeft.Solution(a, d);

            Assert.Equal(expected, result);
        }
    }
}
