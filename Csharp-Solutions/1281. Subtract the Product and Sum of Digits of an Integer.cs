using System;
using System.Linq;

namespace Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubtractProductAndSum(705));
        }
        static int SubtractProductAndSum(int n)
        {
            int A = 0, M = 1;
            int length = n.ToString().Length;
            for (int i = 1; i <= length; i++)
            {
                int dif = Convert.ToInt32(Math.Pow(10, length - i));
                int val = n / dif;
                A += val;
                M *= val;
                int S = val * dif;
                n -= S;
            }
            return M - A;
        }
    }
}