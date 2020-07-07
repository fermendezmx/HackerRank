using HackerRank.Training.DataStructures;
using Xunit;

namespace HackerRank.UnitTest.DataStructures
{
    public class TRansomNote
    {
        [Fact]
        public void Test1()
        {
            string[] m = { "give", "me", "one", "grand", "today", "night" };
            string[] n = { "give", "one", "grand", "today" };
            string expected = "Yes";
            string result = RansomNote.Solution(m, n);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            string[] m = { "two", "times", "three", "is", "not", "four" };
            string[] n = { "two", "times", "two", "is", "four" };
            string expected = "No";
            string result = RansomNote.Solution(m, n);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            string[] m = { "ive", "got", "a", "lovely", "bunch", "of", "coconuts" };
            string[] n = { "ive", "got", "some", "coconuts" };
            string expected = "No";
            string result = RansomNote.Solution(m, n);

            Assert.Equal(expected, result);
        }
    }
}
