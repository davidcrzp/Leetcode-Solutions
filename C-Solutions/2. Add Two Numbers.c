/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode *createNode(int val, struct ListNode* next) {
    struct ListNode *newNode = malloc(sizeof(struct ListNode));
    newNode->val = val;
    newNode->next = next;
    return newNode;
}

struct ListNode* addTwoNumbers(struct ListNode* l1, struct ListNode* l2) {
    int n1[100], n2[100];
    int sum, carry, i = 0, j = 0, count1 = 0, count2 = 0;
    struct ListNode *head = NULL, *curr;

    while(l1 != NULL || l2 != NULL) {
        if(l1 != NULL) {
            n1[count1++] = (int)l1->val;
            l1 = l1->next;
        }
        if(l2 != NULL) {
            n2[count2++] = (int)l2->val;
            l2 = l2->next;
        }
    }

    sum = n1[i++] + n2[j++];
    if(sum > 9) {
        carry = 1;
        sum -= 10;
    } else carry = 0;
    curr = createNode(sum, NULL);
    head = curr;

    while(i < count1 || j < count2 || carry == 1) {
        sum = carry;
        if(i < count1) {
            sum += n1[i++];
        }
        if(j < count2) {
            sum += n2[j++];
        }
        if(sum > 9) {
            carry = 1;
            sum -= 10;
        } else carry = 0;

        curr->next = createNode(sum, NULL);
        curr = curr->next;
    }
    
    return head;
}
