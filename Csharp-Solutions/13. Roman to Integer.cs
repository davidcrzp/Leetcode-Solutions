using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInteger("IV"));
            Console.WriteLine(RomanToInteger("III"));
        }
        static int RomanToInteger(string s)
        {
            Dictionary<string, int> romanNumbersDictionary = new() { { "I", 1 }, { "IV", 4 }, { "V", 5 }, { "IX", 9 }, { "X", 10 }, { "XL", 40 }, { "L", 50 }, { "XC", 90 }, { "C", 100 }, { "CD", 400 }, { "D", 500 }, { "CM", 900 }, { "M", 1000 } };
            int integer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1)
                {
                    if (romanNumbersDictionary[s[i].ToString()] < romanNumbersDictionary[s[i + 1].ToString()]) integer += romanNumbersDictionary[s[i].ToString() + s[++i].ToString()];
                    else integer += romanNumbersDictionary[s[i].ToString()];
                }
                else integer += romanNumbersDictionary[s[i].ToString()];
            }
            return integer;
        }
    }
}