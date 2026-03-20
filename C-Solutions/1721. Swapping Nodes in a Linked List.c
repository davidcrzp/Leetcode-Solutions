/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* swapNodes(struct ListNode* head, int k) {
    if(head->next == NULL) return head;
    else if(head->next->next == NULL) {
        struct ListNode *temp = head->next;
        head->next = NULL;
        temp->next = head;
        head = temp;
        return head;
    }

    struct ListNode *nodeFromStart, *nodeFromEnd;
    struct ListNode *prevFromStart, *prevFromEnd;
    struct ListNode *curr = head;
    int length = 1;
    while(curr->next != NULL) {
        if(length + 1 == k) {
            nodeFromStart = curr->next;
            prevFromStart = curr;
        }
        curr = curr->next;
        length++;
    }
    curr = head;
    for(int i = 0; i < length - k - 1; i++) {
        curr = curr->next;
    }
    prevFromEnd = curr;
    nodeFromEnd = curr->next;

    if(k == 1) {
        nodeFromEnd->next = head->next;
        head->next = NULL;
        prevFromEnd->next = head;
        head = nodeFromEnd;
    } else if(k == length) {
        nodeFromStart->next = head->next;
        head->next = NULL;
        prevFromStart->next = head;
        head = nodeFromStart;
    } else if(k == length - k) {
        nodeFromStart->next = nodeFromEnd->next;
        nodeFromEnd->next = nodeFromStart;
        prevFromStart->next = nodeFromEnd;
    } else if(k == length - k + 2) {
        nodeFromEnd->next = nodeFromStart->next;
        nodeFromStart->next = nodeFromEnd;
        prevFromEnd->next = nodeFromStart;
    } else {
        struct ListNode *temp = nodeFromStart->next;
        nodeFromStart->next = nodeFromEnd->next;
        nodeFromEnd->next = temp;
        prevFromStart->next = nodeFromEnd;
        prevFromEnd->next = nodeFromStart;
    }
    
    return head;
}
