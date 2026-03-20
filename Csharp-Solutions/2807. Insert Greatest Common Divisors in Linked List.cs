using System;

class Program
{
    static void Main(string[] args)
    {
        ListNode head = new ListNode(18);
        head.next = new ListNode(6);
        head.next.next = new ListNode(10);
        head.next.next.next = new ListNode(3);
        ListNode result = InsertGreatestCommonDivisors(head);
        while (result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }

    public static ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        ListNode curr = head;
        ListNode prev = curr;
        int gcd;
        curr = curr.next;
        while (curr != null)
        {
            gcd = GCD(prev.val, curr.val);
            ListNode newNode = new ListNode(gcd, curr);
            prev.next = newNode;
            prev = curr;
            curr = curr.next;
        }
        return head;
    }

    static int GCD(int a, int b)
    {
        int rem;
        while (b != 0)
        {
            rem = a % b;
            a = b;
            b = rem;
        }
        return a;
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