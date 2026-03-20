using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLongestSubstring("abcabcabc"));
    }
    static int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int count = 0;
        int maxCount = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.TryAdd(s[i], 0)) count++;
            else
            {
                char curr = s[i];
                do i--; while (curr != s[i]);
                dic.Clear();
                if (count > maxCount) maxCount = count;
                count = 0;
            }
        }
        if (count > maxCount) maxCount = count;
        return maxCount;
    }
}