using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
        }
        public static bool IsAnagram(string s, string t)
        {
            s.Concat(s.OrderBy(x => x));
            s.Concat(s.OrderBy(x => x));
            Console.WriteLine(s);
            Console.WriteLine(t);
            return s.SequenceEqual(t);
        }
    }
}