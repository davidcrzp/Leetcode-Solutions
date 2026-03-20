typedef struct monotonic_stack {
    int indx;
    struct monotonic_stack *prev;
} stack;

int push(stack **top, int indx, int *nums) {
    stack *new_stack = (stack *)malloc(sizeof(stack));
	new_stack->indx = indx;

    while(*top != NULL) {
        if(nums[indx] < nums[(*top)->indx]) {
            indx = (*top)->indx;
	        new_stack->prev = *top;
	        *top = new_stack;
            return indx;
        }
        stack *temp = *top;
        *top = (*top)->prev;
        free(temp);
    }
	new_stack->prev = NULL;
	*top = new_stack;
    return 0;
}

int free_stack(stack **top) {
	stack *temp;
	while(*top != NULL) {
		temp = *top;
        *top = (*top)->prev;;
        free(temp);
	}
	*top = NULL;
	return 0;
}

int* dailyTemperatures(int* temp, int tempSize, int* returnSize) {
    int *daily_temp = (int *)malloc(tempSize * sizeof(int));
    stack *mono_stack;
    *returnSize = tempSize;

    for(int i = tempSize - 1; i >= 0; i--) {
        int val = push(&mono_stack, i, temp);
        if(val != 0) val -= i;
        daily_temp[i] = val;
    }

    free_stack(&mono_stack);
    return daily_temp;
}
