/*
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
 
struct ListNode* mergeTwoLists(struct ListNode* list1, struct ListNode* list2) {
    if(list1 == NULL) {
        return list2;
    }
    if(list2 == NULL) {
        return list1;
    }      
    
    if(list1->val >= list2->val) {
        struct ListNode *tempNode = createNode(list1->val, list1->next);
        list1->val = list2->val;
        list1->next = tempNode;

        return mergeTwoLists(list1, list2->next);
    } else {
        list1->next = mergeTwoLists(list1->next, list2);
    }

    return list1;
}
