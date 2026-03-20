using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);
            head = DeleteDuplicates(head);
            ListNode curr = head;
            while (curr != null)
            {
                Console.Write(curr.val + " ");
                curr = curr.next;
            }
        }
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            int? uniqueVal = null;
            while (curr != null)
            {
                if (curr.val == uniqueVal)
                {
                    if (prev == null)
                    {
                        while (curr.next != null && curr.next.val == uniqueVal)
                        {
                            curr = curr.next;
                        }
                        head = curr.next;
                    }
                    else
                    {
                        while (curr.next != null && curr.next.val == uniqueVal)
                        {
                            curr = curr.next;
                        }
                        prev.next = curr.next;
                    }
                }
                else uniqueVal = curr.val;
                prev = curr;
                curr = curr.next;
            }
            return head;
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
}