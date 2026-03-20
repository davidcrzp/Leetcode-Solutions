using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            Merge(nums1, 3, nums2, 3);
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int n2 = 0;
            for (int i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[n2];
                n2++;
            }
            Array.Sort(nums1);
        }
    }
}