using System;
using System.Collections;
using System.Linq;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] items1 = { new int[] { 1, 1 }, new int[] { 4, 5 }, new int[] { 3, 8 } };
            int[][] items2 = { new int[] { 3, 1 }, new int[] { 1, 5 } };
            var l = MergeSimilarItems(items1, items2);
            foreach (var item in l)
            {
                foreach (var s in item)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }
        }
        static IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            IList<IList<int>> ret = new List<IList<int>>();
            SortedDictionary<int, int> sd = new();
            for (int i = 0, r = 0; i < items1.Length + items2.Length; i++)
            {
                if (i < items1.Length)
                {
                    sd.Add(items1[i][r], items1[i][r + 1]);
                }
                else
                {
                    try
                    {
                        sd.Add(items2[i - items1.Length][r], items2[i - items1.Length][r + 1]);
                    }
                    catch (Exception)
                    {
                        int n = sd[items2[i - items1.Length][r]];
                        sd.Remove(items2[i - items1.Length][r]);
                        sd.Add(items2[i - items1.Length][r], n + items2[i - items1.Length][r + 1]);
                        continue;
                    }
                }
            }
            foreach (var item in sd)
            {
                ret.Add(new List<int>() { Convert.ToInt32(item.Key), Convert.ToInt32(item.Value) });
            }
            return ret;
        }
    }
}