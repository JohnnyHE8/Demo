using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {

        //Write a program to check for balanced parentheses from an arbitrary string where parentheses are defined as (, [ or { and their respective "closing" parentheses. 

//        Example : String 1: sfhdke(csnd{ dncm}
//        ncdcn[dlkd]

//sfhdke(csnd{ dncm}
//        ncdcn[dlkd] dfjd) 


        static void Main(string[] args)
        {
            string test01 = "sfhdke(csnd{ dncm}ncdcn[dlkd]";
            string test02 = "sfhdke(csnd{dncm}ncdcn[dlkd]dfjd)";
            var result01 = isValid(test01);
            var result02 = isValid(test02);
            Console.WriteLine(result01);
            Console.WriteLine(result02);
            Console.Read();
        }

        public static bool isValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            Stack<char> stack = new Stack<char>();
            foreach (var c in s.ToCharArray())
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');

                if (c == ']' || c == '}' || c == ')')
                {
                    if (stack.Peek() == c)
                        stack.Pop();
                    else
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
