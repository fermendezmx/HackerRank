using HackerRank.Training.Practice;
using Xunit;

namespace HackerRank.UnitTest
{
    public class TRepeatedString
    {
        [Fact]
        public void Test1()
        {
            long n = 10;
            string s = "aba";
            long expected = 7;
            long result = RepeatedString.Solution(s, n);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            long n = 1000000000000;
            string s = "a";
            long expected = 1000000000000;
            long result = RepeatedString.Solution(s, n);

            Assert.Equal(expected, result);
        }
    }
}
