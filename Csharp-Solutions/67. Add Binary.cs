using System;
using System.Text;
using System.Numerics;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"));
        }
        static string AddBinary(string a, string b)
        {
            string result = "";
            int s = 0, i = a.Length - 1, j = b.Length - 1;

            while (i >= 0 || j >= 0 || s == 1)
            {
                s += ((i >= 0) ? a[i--] - '0' : 0);
                s += ((j >= 0) ? b[j--] - '0' : 0);
                result = (char)(s % 2 + '0') + result;

                s /= 2;
            }
            return result;
        }
    }
}