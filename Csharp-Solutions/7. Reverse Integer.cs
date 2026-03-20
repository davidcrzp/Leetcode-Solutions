using System;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));
        }
        static int Reverse(int x)
        {
            var c = x.ToString().ToCharArray();
            Array.Reverse(c);
            var s = new string(c);
            try
            {
                if (s.Last() == '-')
                {
                    return Convert.ToInt32(s.Remove(s.Length - 1)) * -1;
                }
                else
                {
                    return Convert.ToInt32(s);
                }

            }
            catch (System.Exception)
            {
                return 0;
            }
        }
    }
}