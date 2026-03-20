using System;

namespace Can_Make_Arithmetic_Progression_From_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 1 };
            Console.WriteLine(CanMakeArithmeticProgression(arr));
        }
        static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int dif = arr[1] - arr[0];
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i + 1] - arr[i] != dif)
                {
                    Console.WriteLine(arr[i + 1] - arr[i]);
                    return false;
                }
            }
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] - arr[i + 1] != dif)
                {
                    return false;
                }
            }
            return true;
        }
    }
}