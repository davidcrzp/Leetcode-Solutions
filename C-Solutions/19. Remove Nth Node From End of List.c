/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* removeNthFromEnd(struct ListNode* head, int n) {
    struct ListNode *firstPointer = head;
    while(n-- != 0) {
        firstPointer = firstPointer->next;
    }
    if(firstPointer == NULL) {
        firstPointer = head->next;
        free(head);
        head = firstPointer;
        return head;
    } else {
        struct ListNode *secondPointer = head;
        while(firstPointer->next != NULL) {
            firstPointer = firstPointer->next;
            secondPointer = secondPointer->next;
        }
        firstPointer = secondPointer->next->next;
        free(secondPointer->next);
        secondPointer->next = firstPointer;
        return head;
    }
}
