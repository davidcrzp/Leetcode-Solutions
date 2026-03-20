using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] people1 = { 3, 2, 2, 1 };
            int[] people2 = { 3, 5, 3, 4 };
            Console.WriteLine(NumRescueBoats(people2, 5));
        }
        static int NumRescueBoats(int[] people, int limit)
        {
            int boats = 0;
            int min = 0, max = people.Length - 1;
            Array.Sort(people);
            while (min <= max)
            {
                if (people[min] + people[max] <= limit) min++;
                max--;
                boats++;
            }
            return boats++;
        }
    }
}
