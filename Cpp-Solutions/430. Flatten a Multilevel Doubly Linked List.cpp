/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* prev;
    Node* next;
    Node* child;
};
*/

class Solution {
public:
    Node* flatten(Node* head) {
        Node *curr = head;
        Node *currChild, *temp;
        while(curr != NULL) {
            if(curr->child != NULL) {
                temp = curr->next;
                curr->next = curr->child;
                curr->child->prev = curr;
                currChild = curr->child;
                curr->child = NULL;
                while(currChild->next != NULL) {
                    currChild = currChild->next;
                }
                currChild->next = temp;
                if(temp != NULL) {
                    temp->prev = currChild;
                }
            }
            curr = curr->next;
        }
        return head;
    }
};
