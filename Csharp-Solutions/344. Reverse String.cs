using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(s);
            foreach (var item in s)
            {
                Console.WriteLine(s);
            }
        }
        static void ReverseString(char[] s)
        {
            Array.Reverse(s);
        }
    }
}