using HackerRank.Training.Practice;
using Xunit;

namespace HackerRank.UnitTest.Practice
{
    public class TMinimumBribes
    {
        [Fact]
        public void Test1()
        {
            int[] q = { 2, 1, 5, 3, 4 };
            string expected = "3";
            string result = MinimumBribes.Solution(q);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] q = { 2, 5, 1, 3, 4 };
            string expected = "Too chaotic";
            string result = MinimumBribes.Solution(q);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int[] q = { 5, 1, 2, 3, 7, 8, 6, 4 };
            string expected = "Too chaotic";
            string result = MinimumBribes.Solution(q);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            int[] q = { 1, 2, 5, 3, 7, 8, 6, 4 };
            string expected = "7";
            string result = MinimumBribes.Solution(q);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test5()
        {
            int[] q = { 1, 2, 5, 3, 4, 7, 8, 6 };
            string expected = "4";
            string result = MinimumBribes.Solution(q);

            Assert.Equal(expected, result);
        }
    }
}
