/*
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
int getDecimalValue(struct ListNode* head) {
    int n = 0, base = 0;
    struct ListNode *curr = head;

    while(curr != NULL) {
        base++;
        curr = curr->next;
    }

    while(head) {
        n += head->val * pow(2, --base);
        head = head->next;
    }

    return n;
}
