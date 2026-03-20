using System;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your palindrome number: ");
                int x = Convert.ToInt16(Console.ReadLine());
                bool result = Palindrome_Number(x);
                if (result == true)
                {
                    Console.WriteLine("{0} is a palindrome number\n", x);
                }
                if (result == false)
                {
                    Console.WriteLine("{0} is not a palindrome number\n", x);
                }
            }
        }
        static bool Palindrome_Number(int x)
        {
            int reverse = 0;
            int number = x;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            if (x == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}