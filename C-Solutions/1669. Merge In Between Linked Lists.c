/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */


struct ListNode* mergeInBetween(struct ListNode* list1, int a, int b, struct ListNode* list2) {
    struct ListNode *listInBetweenStart, *listInBetweenEnd;
    listInBetweenStart = list1;

    for(int i = 1; i < a; i++)
    {
        listInBetweenStart = listInBetweenStart->next;
    }
    for(int i = 0; i < b - a + 1; i++)
    {
        struct ListNode *temp = listInBetweenStart->next->next;
        free(listInBetweenStart->next);
        listInBetweenStart->next = temp;
    }

    listInBetweenEnd = listInBetweenStart->next;
    listInBetweenStart->next = list2;

    while(list2->next != NULL) {
        list2 = list2->next;
    }
    list2->next = listInBetweenEnd;

    return list1;
}
