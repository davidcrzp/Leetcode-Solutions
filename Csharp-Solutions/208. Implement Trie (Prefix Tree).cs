using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie obj = new Trie();
            obj.Insert("word");
            Console.WriteLine(obj.Search("word"));
            Console.WriteLine(obj.StartsWith("w"));
        }
    }
    public class Trie
    {
        public List<string> l = new List<string>();

        public void Insert(string word)
        {
            l.Add(word);
        }

        public bool Search(string word)
        {
            return l.Contains(word);
        }

        public bool StartsWith(string prefix)
        {
            return l.Any(x => x.StartsWith(prefix));
        }
    }
}