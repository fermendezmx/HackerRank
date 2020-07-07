using System.Collections;

namespace HackerRank.Training.DataStructures
{
    #region Problem

    // Determine if the expression has the parentheses balanced

    #endregion

    public static class BalancedBrackets
    {
        private static char[][] Tokens = {
            new char[] { '{', '}' },
            new char[] { '[', ']' },
            new char[] { '(', ')' }
        };

        public static string Solution(string expression)
        {
            Stack stack = new Stack();

            foreach (var term in expression)
            {
                if (IsOpenTerm(term))
                {
                    stack.Push(term);
                }
                else if (IsEmpty(stack) || !IsMatch((char)stack.Pop(), term))
                {
                    return "NO";
                }
            }

            // The result indicates if it is balanced or not
            return IsEmpty(stack) ? "YES" : "NO";
        }

        private static bool IsOpenTerm(char term)
        {
            foreach (var pair in Tokens)
            {
                // We know pair[0] always constains an open term
                if (pair[0] == term)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsMatch(char openTerm, char closeTerm)
        {
            foreach (var pair in Tokens)
            {
                // We know pair[0] always constains an open term
                if (pair[0] == openTerm)
                {
                    // And pair[1] always constains a close term
                    return pair[1] == closeTerm;
                }
            }

            return false;
        }

        private static bool IsEmpty(Stack stack)
        {
            return stack.Count == 0;
        }
    }
}
