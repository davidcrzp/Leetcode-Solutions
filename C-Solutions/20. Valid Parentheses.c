struct stack {
    char c;
    struct stack *next;
};

void push(struct stack **curr_stack, char c) {
    struct stack *new_stack = malloc(sizeof(struct stack));
    new_stack->c = c;
    new_stack->next = NULL;

    if(*curr_stack == NULL) {
        *curr_stack = new_stack;
    } else {
        new_stack->next = *curr_stack;
        *curr_stack = new_stack;
    }
}

char pop(struct stack **curr_stack) {
    if(*curr_stack == NULL) return '1';
    struct stack *temp = (*curr_stack)->next;
    char char_pop = (*curr_stack)->c;

    free(*curr_stack);
    *curr_stack = temp;

    return char_pop;
}

void free_stack(struct stack **curr_stack) {
    struct stack *temp;
    while(*curr_stack != NULL) {
        temp = (*curr_stack)->next;
        free(*curr_stack);
        *curr_stack = temp;
    }
}

bool isValid(char* s) {
    struct stack *valid_parentheses;

    for(int i = 0; s[i] != '\0'; i++) {
        if(s[i] == '(' || s[i] == '[' || s[i] == '{') {
            push(&valid_parentheses, s[i]);
        } else {
            char op = pop(&valid_parentheses);

            switch(s[i]) {
                case ')':
                    if(op != '(') {
                        free_stack(&valid_parentheses);
                        return false;
                    }
                    break;
                case ']':
                    if(op != '[') {
                        free_stack(&valid_parentheses);
                        return false;
                    }
                    break;
                case '}':
                    if(op != '{') {
                        free_stack(&valid_parentheses);
                        return false;
                    }
                    break;
                default:
                    return false;
            }
        }
    }
    if(valid_parentheses != NULL) {
        free_stack(&valid_parentheses);
        return false;
    }
    return true;
}
