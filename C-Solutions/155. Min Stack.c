typedef struct {
    int val;
    struct Stack *prev;
} Stack;

typedef struct {
    Stack *stack;
    Stack *minStack;
} MinStack;


MinStack* minStackCreate() {
    MinStack *newStack = malloc(sizeof(MinStack));
    newStack->stack = NULL;
    newStack->minStack = NULL;
    return newStack;
}

void minStackPush(MinStack* obj, int val) {
    if(obj->minStack != NULL) {
        if(obj->minStack->val >= val) {
            Stack *new = malloc(sizeof(Stack));
            new->val = val;
            new->prev = obj->minStack;
            obj->minStack = new;
        }
    } else {
        obj->minStack = malloc(sizeof(Stack));
        obj->minStack->val = val;
        obj->minStack->prev = NULL;
    }
  
    Stack *new = malloc(sizeof(Stack));
    new->val = val;
    if(obj->stack == NULL) {
        new->prev = NULL;
        obj->stack = new;
    } else {
        new->prev = obj->stack;
        obj->stack = new;
    }
}

void minStackPop(MinStack* obj) {
    Stack *temp;
    if(obj->minStack != NULL && obj->stack->val == obj->minStack->val) {
        obj->minStack->val;
        temp = obj->minStack;
        obj->minStack = obj->minStack->prev;
        free(temp);
    }
    temp = obj->stack;
    obj->stack = obj->stack->prev;
    free(temp);
}

int minStackTop(MinStack* obj) {
    return obj->stack->val;
}

int minStackGetMin(MinStack* obj) {
    return obj->minStack->val;
}

void minStackFree(MinStack* obj) {
    Stack *temp;
    while(obj->stack != NULL) {
        temp = obj->stack;
        obj->stack = obj->stack->prev;
        free(temp);
    }
    while(obj->minStack != NULL) {
        temp = obj->minStack;
        obj->minStack = obj->minStack->prev;
        free(temp);
    }
    free(obj);
}

/**
 * Your MinStack struct will be instantiated and called as such:
 * MinStack* obj = minStackCreate();
 * minStackPush(obj, val);
 
 * minStackPop(obj);
 
 * int param_3 = minStackTop(obj);
 
 * int param_4 = minStackGetMin(obj);
 
 * minStackFree(obj);
*/
