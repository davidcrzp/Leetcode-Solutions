/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* reverseKGroup(struct ListNode* head, int k) {
    if(k == 1) {
        return head;
    }

    struct ListNode *curr, *prev, *next, *temp, *connect;
    int groups = 0, indx = 0;

    curr = head;
    prev = next = connect = NULL;
    while(curr != NULL) {
        groups++;
        curr = curr->next;
    }
    groups = floor(groups / k);
    struct ListNode *nodeGroups[groups * 2];
    curr = head;

    while(curr != NULL && groups-- > 0) {
        temp = curr;
        for(int i = 0; i < k; i++) {
            next = curr->next;
            curr->next = prev;
            prev = curr;
            curr = next;
        }

        nodeGroups[indx++] = prev;
        if(indx > 2) {
            nodeGroups[indx - 2]->next = nodeGroups[indx - 1];
        }
        nodeGroups[indx++] = temp;
        if(groups == 0) {
            nodeGroups[indx - 1]->next = curr;
        }
    }
    head = nodeGroups[0];
    return head;
}
