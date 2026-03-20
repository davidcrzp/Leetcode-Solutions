using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = head;
            Console.WriteLine(DetectCycle(head));
        }
        public static ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> finder = new HashSet<ListNode>();
            ListNode curr = head;
            while (curr != null)
            {
                if (finder.Contains(curr)) return curr;
                finder.Add(curr);
                curr = curr.next;
            }
            return null;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}