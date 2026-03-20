/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* swapPairs(struct ListNode* head) {
    if(head == NULL) return head;
    else if(head->next == NULL) return head;

    struct ListNode *curr = head;
    struct ListNode *next;
    head = head->next;
    while(curr->next != NULL) {
        next = curr->next;
        curr->next = next->next;
        next->next = curr;

        if(curr->next == NULL) {
            break;
        }
        next = curr;
        curr = curr->next;
        if(curr->next != NULL) {
            next->next = curr->next;
        }
    }
    return head;
}
