bool isAnagram(char* s, char* t) {
    int *letterCount1, *letterCount2, i;
    letterCount1 = calloc(26, sizeof(int));
    letterCount2 = calloc(26, sizeof(int));
    for(i = 0; s[i] != '\0' && t[i] != '\0'; i++) {
        if((int)s[i] - 97 >= 0 && (int)s[i] - 97 <= 26 && (int)t[i] - 97 >= 0 && (int)t[i] - 97 <= 26) {
            letterCount1[(int)s[i] - 97]++;
            letterCount2[(int)t[i] - 97]++;
        } else return false;
    }
    if(!(s[i] == '\0' && t[i] == '\0')) {
        return false;
    }
    for(i = 0; i < 26; i++) {
        if(letterCount1[i] != letterCount2[i]) {
            return false;
        }
    }
    free(letterCount1);
    free(letterCount2);
    return true;
}
