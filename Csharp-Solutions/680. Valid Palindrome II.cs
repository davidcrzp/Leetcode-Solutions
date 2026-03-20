using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ValidPalindrome("abca"));
    }
    static bool ValidPalindrome(string s)
    {
        int count = 0, c = 2, _k = 0;
        string _s = s;
        for (int i = 0, k = s.Length - 1; i < s.Length; i++, k--)
        {
            if (s[i] == s[k]) count++;
            else if (c == 1)
            {
                s = _s;
                s = s.Remove(_k, 1);
                count = 0;
                i = 0;
                k = s.Length - 1;
                c--;
            }
            else if (c == 2)
            {
                s = s.Remove(i, 1);
                _k = k;
                count = 0;
                i = 0;
                k = s.Length - 1;
                c--;
            }
            else break;
        }
        return count >= s.Length - 1;
    }
}