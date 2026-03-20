using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(0));
            Console.WriteLine(Fib(1));
            Console.WriteLine(Fib(2));
            Console.WriteLine(Fib(3));
            Console.WriteLine(Fib(20));
        }
        static int Fib(int n)
        {
            if (n < 2) return n;
            int f = 0;
            int n1 = 1;
            int n2 = 0;
            for (int i = 0; i < n - 1; i++)
            {
                f = n1 + n2;
                n2 = n1;
                n1 = f;
            }
            return f;
        }
    }
}