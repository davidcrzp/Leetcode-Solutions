/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* rotateRight(struct ListNode* head, int k) {
    struct ListNode *end;
    int length, new_head;

    if(head == NULL || head->next == NULL || k == 0) return head;

    end = head;
    for(length = 0; end->next != NULL; length++) {
        end = end->next;
    }
    
    k %= length + 1;
    if(k == 0) return head;

    end->next = head;
    for(int i = 0; i < length - k; i++) {
        head = head->next;
    }
    end = head;
    head = head->next;
    end->next = NULL;

    return head;
}
