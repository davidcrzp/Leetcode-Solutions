using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };

            int[] display = PlusOne(digits);
            for (int i = 0; i < display.Length; i++)
            {
                Console.WriteLine(display[i]);
            }
        }
        public static int[] PlusOne(int[] digits)
        {
            BigInteger bigInteger = new BigInteger(0);
            foreach (var c in digits)
            {
                bigInteger *= 10;
                if (c != 0)
                    bigInteger += c;
            }
            bigInteger++;
            string str = bigInteger.ToString();
            if (str.Length > digits.Length) Array.Resize(ref digits, digits.Length + 1);
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = str[i] - '0';
            }
            return digits;
        }
    }
}