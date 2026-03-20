using System;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthofLastWord("Hello World"));
            Console.WriteLine(LengthofLastWord("   fly me   to   the moon  "));
        }
        static int LengthofLastWord(string s)
        {
            int x = 123;
            x.ToString().Reverse();
            return s.TrimEnd().Split(' ').Last().Length;
        }
    }
}