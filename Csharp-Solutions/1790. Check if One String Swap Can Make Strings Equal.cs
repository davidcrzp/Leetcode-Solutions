using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Check_if_One_String_Swap_Can_Make_Strings_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreAlmostEqual("bank", "kanb"));
        }
        static bool AreAlmostEqual(string s1, string s2)
        {
            char[] st1 = s1.ToArray();
            char[] st2 = s2.ToArray();
            int i = 0, j = 0;
            int[] n = new int[3];
            while (j < 3 && i < st1.Length)
            {
                if (st1[i] != st2[i]) { n[j] = i; j++; }
                i++;
            }
            return (j == 0 || j == 2) && (st1[n[0]] == st2[n[1]] && st1[n[1]] == st2[n[0]]);
        }
    }
}