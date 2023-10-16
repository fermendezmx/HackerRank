using HackerRank.Training.Practice;
using Xunit;

namespace HackerRank.UnitTest.Practice
{
    public class TSherlockAndAnagrams
    {
        [Fact]
        public void Test1()
        {
            string input = "abba";
            int expected = 4;
            int result = SherlockAndAnagrams.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            string input = "abcd";
            int expected = 0;
            int result = SherlockAndAnagrams.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            string input = "ifailuhkqq";
            int expected = 3;
            int result = SherlockAndAnagrams.Solution(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            string input = "kkkk";
            int expected = 10;
            int result = SherlockAndAnagrams.Solution(input);

            Assert.Equal(expected, result);
        }
    }
}
