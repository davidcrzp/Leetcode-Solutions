using System;

namespace Average_Salary_Excluding_the_Minimum_and_Maximum_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salary = { 4000, 3000, 1000, 2000 };
            double result = Average(salary);
            Console.WriteLine(result);
        }
        public static double Average(int[] salary)
        {
            double[] mid = new double[salary.Length - 1];
            double average = 0;
            Array.Sort(salary);
            for (int i = 1; i < salary.Length - 1; i++)
            {
                mid[i] = salary[i];
                Console.WriteLine(mid[i]);
            }
            foreach (var c in mid)
            {
                average += c;
            }
            return average / (mid.Length - 1);
        }
    }
}