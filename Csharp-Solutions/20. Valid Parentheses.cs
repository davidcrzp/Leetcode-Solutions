using System;
using System.Collections;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "()"; // True
            Console.WriteLine(IsValid(s1));
            string s2 = "()[]{}"; // True
            Console.WriteLine(IsValid(s2));
            string s3 = "(]"; // False
            Console.WriteLine(IsValid(s3));
            string s4 = "([)]"; // False
            Console.WriteLine(IsValid(s4));
            string s5 = "{[]}"; // True
            Console.WriteLine(IsValid(s5));
            string s6 = "}"; // False
            Console.WriteLine(IsValid(s6));
            string s7 = "}{"; // False
            Console.WriteLine(IsValid(s7));
        }
        static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) { return false; }
            int result;
            var order = new Stack<int>();
            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        order.Push(1);
                        continue;
                    case '[':
                        order.Push(2);
                        continue;
                    case '{':
                        order.Push(3);
                        continue;
                }
                switch (c)
                {
                    case ')':
                        order.TryPeek(out result);
                        if (result != 1) { return false; }
                        order.Pop();
                        continue;
                    case ']':
                        order.TryPeek(out result);
                        if (result != 2) { return false; }
                        order.Pop();
                        continue;
                    case '}':
                        order.TryPeek(out result);
                        if (result != 3) { return false; }
                        order.Pop();
                        continue;
                }
            }
            if (order.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}