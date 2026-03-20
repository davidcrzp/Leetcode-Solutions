using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] nums1 = { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 4, 5 } };
            int[][] nums2 = { new int[] { 1, 4 }, new int[] { 3, 2 }, new int[] { 4, 1 } };
            var r = MergeArrays(nums1, nums2);
            foreach (var item in r)
            {
                foreach (var s in item)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }
        }
        static int[][] MergeArrays(int[][] nums1, int[][] nums2)
        {
            int[][] ret = new int[nums1.Length + nums2.Length][];
            SortedDictionary<int, int> sd = new();
            for (int i = 0, r = 0; i < nums1.Length + nums2.Length; i++)
            {
                if (i < nums1.Length)
                {
                    sd.Add(nums1[i][r], nums1[i][r + 1]);
                }
                else
                {
                    try
                    {
                        sd.Add(nums2[i - nums1.Length][r], nums2[i - nums1.Length][r + 1]);
                    }
                    catch (Exception)
                    {
                        int n = sd[nums2[i - nums1.Length][r]];
                        sd.Remove(nums2[i - nums1.Length][r]);
                        sd.Add(nums2[i - nums1.Length][r], n + nums2[i - nums1.Length][r + 1]);
                        continue;
                    }
                }
            }
            int k = 0;
            foreach (var item in sd)
            {
                ret[k++] = new int[] { Convert.ToInt32(item.Key), Convert.ToInt32(item.Value) };
            }
            ret = ret.TakeWhile(x => x != null).ToArray();
            return ret;
        }
    }
}