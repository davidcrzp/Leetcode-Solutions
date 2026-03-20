using System;

namespace Richest_Customer_Wealth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts = { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } };
            Console.WriteLine(MaximumWealth(accounts));
        }
        static int MaximumWealth(int[][] accounts)
        {
            int[] wealth = new int[accounts.Length];
            for (int i = 0; i < accounts.Length; i++)
            {
                wealth[i] = accounts[i].Sum();
            }
            return wealth.Max();
        }
    }
}