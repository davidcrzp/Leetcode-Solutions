int comp(const void *a, const void *b) {
    return *(int*)b - *(int*)a;
}

int minimumBoxes(int* apple, int appleSize, int* capacity, int capacitySize) {
    if(capacitySize == 1) return 1;
    qsort(capacity, capacitySize, sizeof(capacity[0]), comp);
    int box = 0;
    for(int i = 0; i < appleSize; i++) {
        if(capacity[box] - apple[i] > 0) {
            capacity[box] -= apple[i];
        } else if(capacity[box] - apple[i] == 0) {
            if(i + 1 == appleSize) break;
            box++;
        } else apple[i--] -= capacity[box++];
    }
    return box + 1;
}
