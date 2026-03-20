long long getDescentPeriods(int* prices, int pricesSize) {
    long count = 0;
    long contiguous = 1;
    for(int i = 0; i < pricesSize - 1; i++) {
        if(*prices - *(prices + 1) == 1) {
            contiguous++;
        } else {
            count += (contiguous * (contiguous + 1)) / 2;
            contiguous = 1;
        }
        prices++;
    }
    if(contiguous != 1) count += (contiguous * (contiguous + 1)) / 2;
    if(contiguous == 1) count++;
    return count;
}
