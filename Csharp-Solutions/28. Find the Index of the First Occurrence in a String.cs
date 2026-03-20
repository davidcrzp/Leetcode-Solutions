using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            StrStr("sadbutsad", "sad");
            StrStr("leetcode", "leeto");
        }
        static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}