using System;

namespace To_Lower_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerCase("Hello Wolrd!"));
        }
        static string ToLowerCase(string s)
        {
            return s.ToLower();
        }
    }
}