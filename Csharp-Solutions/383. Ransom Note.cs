using System;

namespace Ransom_Note
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "aab", b = "ab";
            Console.WriteLine(CanConstruct(a, b));
        }
        static bool CanConstruct(string ransomNote, string magazine)
        {
            foreach (var c in ransomNote)
            {
                if (magazine.Contains(c)) magazine = magazine.Remove(magazine.IndexOf(c), 1);
                else return false;
            }
            return true;
        }
    }
}