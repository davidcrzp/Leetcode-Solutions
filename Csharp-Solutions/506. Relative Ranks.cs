using System;
using System.Collections;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 10, 3, 8, 9, 4 };
            var result = FindRelativeRanks(score);
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }
        static string[] FindRelativeRanks(int[] score)
        {
            int[] sc = score.ToArray();
            int n = score.Length;
            Array.Sort(score);
            Hashtable ht = new();
            string[] res = new string[n];
            int p = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                ht.Add(score[i], p++);
            }
            p = 0;
            for (int i = 0; i < n; i++)
            {
                res[i] = ht[sc[i]].ToString();
                Console.WriteLine(sc[i] + " " + ht[sc[i]]);
                if (res[i] == "1") res[i] = "Gold Medal";
                if (res[i] == "2") res[i] = "Silver Medal";
                if (res[i] == "3") res[i] = "Bronze Medal";
            }
            Console.WriteLine();
            return res;
        }
    }
}