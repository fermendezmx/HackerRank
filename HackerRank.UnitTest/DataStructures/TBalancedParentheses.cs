using HackerRank.Training.DataStructures;
using Xunit;

namespace HackerRank.UnitTest.DataStructures
{
    public class TBalancedParentheses
    {
        [Fact]
        public void Test1()
        {
            string input = "{()[{({})[]()}]}([])";
            bool result = BalancedParentheses.Solution(input);

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            string input = "{()[{({}){]}()}]}([])";
            bool result = BalancedParentheses.Solution(input);

            Assert.False(result);
        }
    }
}
