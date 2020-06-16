using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Parentheses
{
    public static class ParenthesisMatcher
    {
        /// <summary>
        /// Determines whether the given character is an opening parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is an opening parenthesis.</returns>
        private static bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        /// <summary>
        /// Determines whether the given character is a closing parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is a closing parenthesis.</returns>
        private static bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        /// <summary>
        /// Determines whether the given characters form a matched pair
        /// of parentheses.
        /// </summary>
        /// <param name="a">The opening character.</param>
        /// <param name="b">The closing character.</param>
        /// <returns>Whether a and b form a matched pair of parentheses.</returns>
        private static bool Matches(char a, char b)
        {
            return (a == '(' && b == ')') || (a == '[' && b == ']') ||
                (a == '{' && b == '}');
        }

        public static bool IsBalanced(string s)
        { 
            
        }
    }

}
