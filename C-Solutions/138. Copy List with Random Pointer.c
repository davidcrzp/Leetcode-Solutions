/**
 * Definition for a Node.
 * struct Node {
 *     int val;
 *     struct Node *next;
 *     struct Node *random;
 * };
 */
struct Node *createNode(struct Node* node) {
    struct Node *newNode = malloc(sizeof(struct Node));
    newNode->val = node->val;
    newNode->next = node->next;
    newNode->random = NULL;
    return newNode;
}

struct Node* copyRandomList(struct Node* head) {
	if(head == NULL) {
        return NULL;
    }

    struct Node *curr = head;
    while(curr != NULL) {
        curr->next = createNode(curr);
        curr = curr->next->next;
    }

    struct Node *temp;
    curr = head;
    while(curr != NULL) {
        if(curr->random == NULL) {
            curr->next->random = NULL;
        } else {
            curr->next->random = curr->random->next;
        }
        temp = curr->next->next;
        curr = curr->next;
        if(curr->next != NULL) {
            curr->next = curr->next->next;
        }
        curr = temp;
    }
    temp = head->next;
    head->next = head->next->next;
    
    return temp;
}
