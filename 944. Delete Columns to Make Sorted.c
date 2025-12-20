int minDeletionSize(char** strs, int strsSize) {
    int deleted;
    for(int i = 0; strs[0][i] != '\0'; i++) {
        for(int j = 0; j < strsSize - 1; j++) {
            if(strs[j][i] > strs[j + 1][i]) {
                deleted++;
                break;
            }
        }
    }
    return deleted;
}
