int evalRPN(char** tokens, int tokensSize) {
	int solve_stack[tokensSize], index = 0;
    int num1, num2;
	if(tokensSize == 1) {
		return atoi(tokens[0]);
	}
	for(int i = 0; i < tokensSize; i++) {
		if((num1 = atoi(tokens[i])) != 0 || tokens[i][0] == '0') {
            solve_stack[index++] = num1;
		} else {
			num2 = solve_stack[--index];
			num1 = solve_stack[--index];

			switch(tokens[i][0]) {
				case '+':
					solve_stack[index++] = num1 + num2;
					break;
				case '-':
					solve_stack[index++] = num1 - num2;
					break;
				case '*':
					solve_stack[index++] = num1 * num2;
					break;
				case '/':
					solve_stack[index++] = num1 / num2;
                    break;
				default:
                    return -1;
			}
		}
	}

	return solve_stack[0];
}
