/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* twoSum(int* numbers, int numbersSize, int target, int* returnSize) {
    int *twoIndex = (int*)malloc(2 * sizeof(int));;
    *returnSize = 2;

    for(int i = 0, j = numbersSize - 1; i < j;) {
        if(numbers[i] + numbers[j] == target) {
            twoIndex[0] = i + 1;
            twoIndex[1] = j + 1;
            return twoIndex;
        } else if(numbers[i] + numbers[j] < target) {
            i++;
        } else {
            j--;
        }
    }

    return -1;
}
