using System;
using System.Collections;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomizedSet obj = new RandomizedSet();
            bool param_1 = obj.Insert(123);
            bool param_2 = obj.Remove(123);
            int param_3 = obj.GetRandom();
        }
    }
    public class RandomizedSet
    {
        HashSet<int> hs;
        Random rnd = new Random();
        public RandomizedSet()
        {
            hs = new HashSet<int>();
        }

        public bool Insert(int val)
        {
            return hs.Add(val);
        }

        public bool Remove(int val)
        {
            return hs.Remove(val);
        }

        public int GetRandom()
        {
            return hs.ElementAt(rnd.Next(hs.Count()));
        }
    }
}