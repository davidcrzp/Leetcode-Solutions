int removeDuplicates(int* nums, int numsSize){
    int prev, index, uniq;
    prev = nums[0];
    uniq = 1;
    index = 0;
    for (int i = 0; i < numsSize; i++){
        if (prev != nums[i]){
            uniq++;
            prev = nums[i];
            nums[index + 1] = nums[i];
            index++;
        }
    }
    return uniq;
}
