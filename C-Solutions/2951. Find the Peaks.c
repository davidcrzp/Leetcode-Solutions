/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* findPeaks(int* mountain, int mountainSize, int* returnSize) {
    int *peaks = (int*)malloc(sizeof(int)*(mountainSize / 2));
    int i, j = 0;
    for(i = 1; i < mountainSize - 1; i++){
        if(mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1]) peaks[j++] = i;
    }
    *returnSize = j;
    return peaks;
}
