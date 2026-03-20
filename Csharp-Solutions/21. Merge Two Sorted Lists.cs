using System;

namespace Merge_Two_Sorted_Lists
{
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

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                // If list1 (usually recursively sent list1.next) is null, this means that we reached the end of list1 (there is no .next node where to point)
                // So we wanna append list2 to the list1 (will result in original tail of list1's .next pointer pointing to the whole list2)
                // By that we appended remaining elements of the list2 that are already non-decreasingly ordered
                return list2;
            }
            if (list2 == null)
            {
                // If list2 is null, since we want to return list1 as a final result, recursion should end here 
                // Because we don't have anything to append to list1 anymore
                return list1;
            }

            // Comparing values and inserting them into non-decreasing order, while maintaining pointer to the head of list1 here:

            // If list1.val >= list.val, insert new "tempNode" with the current list1.val and list1.next, then change list1's val and .next pointer to tempNode
            // Can't simply insert tempNode before list1 because we can't access previous list1's node to set its next pointer to tempNode
            // That's why we insert it after the current list1 node
            if (list1.val >= list2.val)
            {
                ListNode tempNode = new ListNode(list1.val, list1.next);
                list1.val = list2.val;
                list1.next = tempNode;

                return MergeTwoLists(list1, list2.next);
            }
            // When list2.val is bigger than list1.val
            // We then want to go to the next node in list1 and perform the check above
            else
            {
                list1.next = MergeTwoLists(list1.next, list2);
            }

            return list1;
        }
    }
}