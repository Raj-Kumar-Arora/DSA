using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_20_Easy
    {
        public static void IsValid()
        {
            ////Case - 1
            //string s = "()";
            //bool expOutput = true;

            ////Case - 2
            //string s = "()[]{}";
            //bool expOutput = true;

            ////CASE - 3 
            //string s = "(]";
            //bool expOutput = false;

            //Case - 4
            string s = "]";
            //bool expOutput = false;

            //Case - 5
            //string s = "";
            //bool expOutput = 0;


            bool actualOutput = IsValid(s);

            Console.WriteLine("actualOutput = " + actualOutput);
        }
        public static bool IsValid(string s)
        {
            Stack<char> stack = new();

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                switch (ch)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(ch); break;
                    case ')':
                        {
                            // check if it matches the previous parentheses
                            if (stack.Count > 0)
                            {
                                char lastChar = stack.Pop();
                                if (lastChar != '(')
                                    return false;
                            }
                            // if ) or } or ] is received as first char or without its matching open parentheses
                            else
                                return false;
                            break;
                        }
                    case '}':
                        {
                            // check if it matches the previous parentheses
                            if (stack.Count > 0)
                            {
                                char lastChar = stack.Pop();
                                if (lastChar != '{')
                                    return false;
                            }
                            // if ) or } or ] is received as first char or without its matching open parentheses
                            else
                                return false;
                            break;
                        }
                    case ']':
                        {
                            // check if it matches the previous parentheses
                            if (stack.Count > 0)
                            {
                                char lastChar = stack.Pop();
                                if (lastChar != '[')
                                    return false;
                            }
                            // if ) or } or ] is received as first char or without its matching open parentheses
                            else
                                return false;
                            break;
                        }
                    default:
                        return false;

                }
            }

            //if stack still have some open parentheses
            if (stack.Count > 0)
                return false;

            return true;
        }
    }
}