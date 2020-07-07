using HackerRank.Training.DataStructures;
using Xunit;

namespace HackerRank.UnitTest.DataStructures
{
    public class TBalancedBrackets
    {
        [Fact]
        public void Test1()
        {
            string input = "{()[{({})[]()}]}([])";
            string expected = "YES";
            string result = BalancedBrackets.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            string input = "{[()]}";
            string expected = "YES";
            string result = BalancedBrackets.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            string input = "{[(])}";
            string expected = "NO";
            string result = BalancedBrackets.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            string input = "{{[[(())]]}}";
            string expected = "YES";
            string result = BalancedBrackets.Solution(input);

            Assert.Equal(expected, result);
        }
    }
}
