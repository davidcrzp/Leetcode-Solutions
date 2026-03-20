using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomizedCollection obj = new RandomizedCollection();
            bool param_1 = obj.Insert(123);
            bool param_2 = obj.Remove(123);
            int param_3 = obj.GetRandom();
        }
    }
    public class RandomizedCollection
    {
        List<int> l;
        Random rnd = new Random();

        public RandomizedCollection()
        {
            l = new List<int>();
        }

        public bool Insert(int val)
        {
            if (l.Contains(val))
            {
                l.Add(val);
                return false;
            }
            else
            {
                l.Add(val);
                return true;
            }
        }

        public bool Remove(int val)
        {
            return l.Remove(val);
        }

        public int GetRandom()
        {
            return l.ElementAt(rnd.Next(l.Count));
        }
    }
}