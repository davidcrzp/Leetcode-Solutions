using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new ListNode(1);
            node1.next = new ListNode(4);
            node1.next.next = new ListNode(5);
            var node2 = new ListNode(1);
            node2.next = new ListNode(3);
            node2.next.next = new ListNode(4);
            var node3 = new ListNode(2);
            node3.next = new ListNode(6);
            ListNode[] lists = { node1, node2, node3 };
            var res = MergeKLists(lists);
            while (res != null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
        }
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            var newListNode = lists[0];
            for (int i = 1; i < lists.Length; i++)
            {
                var temp = new ListNode();
                var prev = temp;
                while (newListNode != null && lists[i] != null)
                {
                    if (newListNode.val <= lists[i].val)
                    {
                        prev.next = newListNode;
                        newListNode = newListNode.next;
                    }
                    else
                    {
                        prev.next = lists[i];
                        lists[i] = lists[i].next;
                    }
                    prev = prev.next;
                }
                if (newListNode == null) { prev.next = lists[i]; }
                if (lists[i] == null) { prev.next = newListNode; }
                newListNode = temp.next;
            }
            return newListNode;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}