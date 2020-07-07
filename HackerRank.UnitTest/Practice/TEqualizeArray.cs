using HackerRank.Training.Practice;
using Xunit;

namespace HackerRank.UnitTest.Practice
{
    public class TEqualizeArray
    {
        [Fact]
        public void Test1()
        {
            int[] input = { 3, 3, 2, 1, 3 };
            long expected = 2;
            long result = EqualizeArray.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] input = { 1, 2, 3, 1, 2, 3, 3, 3 };
            long expected = 4;
            long result = EqualizeArray.Solution(input);

            Assert.Equal(expected, result);
        }
    }
}
