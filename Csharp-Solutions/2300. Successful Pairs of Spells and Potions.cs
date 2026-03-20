using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] spells = { 5, 1, 3 };
            int[] potions = { 1, 2, 3, 4, 5 };
            int[] res = SuccessfulPairs(spells, potions, 7);
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
        }
        public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            int[] res = new int[spells.Length];
            for (int i = 0; i < spells.Length; i++)
            {
                int min = 0;
                int max = potions.Length - 1;
                int mid;
                while (min <= max)
                {
                    mid = (min + max) / 2;
                    long prod = (long)spells[i] * potions[mid];
                    if (prod >= success)
                    {
                        if (mid == 0) { res[i] = potions.Length; break; }
                        else if ((long)spells[i] * potions[mid - 1] < success) { res[i] = potions.Length - mid; break; }
                        else max = mid - 1;
                    }
                    else min = mid + 1;
                }
            }
            return res;
        }
    }
}