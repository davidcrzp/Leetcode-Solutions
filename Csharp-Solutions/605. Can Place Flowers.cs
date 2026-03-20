using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            Console.WriteLine(CanPlaceFlowers(flowerbed, 1));
            Console.WriteLine(CanPlaceFlowers(flowerbed, 2));
        }
        static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int d = 0;
            for (int i = 0; i < flowerbed.Length && n > 0; i++)
            {
                if (flowerbed[i] == 1) d = 1;
                else if (d == 1 || d == 2) d = 0;
                else
                {
                    d = 2;
                    n--;
                    try { if (flowerbed[i + 1] == 1) { n++; d = 1; } }
                    catch { break; }
                }
            }
            return n == 0;
        }
    }
}