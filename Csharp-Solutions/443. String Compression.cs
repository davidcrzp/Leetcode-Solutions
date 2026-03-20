using System;
using System.Collections;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c1 = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            char[] c2 = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            Console.WriteLine(Compress(c1));
        }
        static int Compress(char[] chars)
        {
            int group = 1;
            string s = " ";
            foreach (var c in chars)
            {
                if (s.Last() != c)
                {
                    if (group != 1) s += group;
                    s += c;
                    group = 1;
                    continue;
                }
                group++;
            }
            if (group != 1) s += group;
            for (int i = 0; i < s.Length - 1; i++)
            {
                chars[i] = s[i + 1];
            }
            return s.Length - 1;
        }
    }
}