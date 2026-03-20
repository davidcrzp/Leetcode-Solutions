using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 7, 11, 15 };
        int[] res = TwoSum(numbers, 9);
        foreach (var item in res) Console.WriteLine(item);
    }
    static int[] TwoSum(int[] numbers, int target)
    {
        int[] res = new int[2];
        int i = 0;
        int search = 0;
        for (i = 0; i < numbers.Length; i++)
        {
            search = Search(i, numbers, target);
            if (search != -1) break;
        }
        res[0] = i + 1;
        res[1] = search + 1;
        return res;
    }
    static int Search(int i, int[] nums, int target)
    {
        int min = 0;
        int max = nums.Length - 1;
        int mid;
        while (min <= max)
        {
            mid = (min + max) / 2;
            if (mid == i) mid += 1;
            if (nums[mid] + nums[i] == target) return mid;
            else if (nums[mid] + nums[i] > target) max = mid - 1;
            else min = mid + 1;
        }
        return -1;
    }
}