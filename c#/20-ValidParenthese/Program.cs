using System.Collections.Generic;
using System.Linq;

namespace _20_ValidParenthese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "(){}";
            Console.WriteLine(IsValid(s));
        }

        public static bool IsValid(string s)
        {
            Dictionary<char, char> parenthese = new ()
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };

            Stack<char> visited = new ();

            for (int i = 0; i < s.Length; i++)
            {
                if (parenthese.ContainsKey(s[i]))
                {
                    visited.Push(s[i]);
                }
                else if (parenthese.ContainsValue(s[i]))
                {
                    if (visited.Count == 0 || parenthese[visited.Pop()] != s[i])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return visited.Count == 0;
        }
    }
}
