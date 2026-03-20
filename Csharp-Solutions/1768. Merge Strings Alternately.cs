using System;

namespace Merge_Strings_Alternately
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MergeAlternately("abc", "efgsd"));
        }
        static string MergeAlternately(string word1, string word2)
        {
            string merged = String.Empty;
            int l = Math.Min(word1.Length, word2.Length);
            for (int i = 0; i < l; i++)
            {
                merged += word1[0];
                merged += word2[0];
                word1 = word1.Remove(0, 1);
                word2 = word2.Remove(0, 1);
            }
            if (word1.Length != 0) return merged + word1;
            if (word2.Length != 0) return merged + word2;
            return merged;
        }
    }
}