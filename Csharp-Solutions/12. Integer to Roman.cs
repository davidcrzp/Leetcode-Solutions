using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution(4321);
        }
        static string Solution(int n)
        {
            Dictionary<int, string> dic = new() { { 1, "I" }, { 4, "IV" }, { 5, "V" }, { 9, "IX" }, { 10, "X" }, { 40, "XL" }, { 50, "L" }, { 90, "XC" }, { 100, "C" }, { 400, "CD" }, { 500, "D" }, { 900, "CM" }, { 1000, "M" } };
            string s = n.ToString();
            string roman = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0') continue;
                int number = (s[i] - '0') * ((int)Math.Pow(10, s.Length - i - 1));
                while (number != 0)
                {
                    int maxWhere = dic.Keys.Where(x => x <= number).Max();
                    roman += dic[maxWhere];
                    number -= maxWhere;
                }
            }
            Console.WriteLine(roman);
            return roman;
        }
    }
}
