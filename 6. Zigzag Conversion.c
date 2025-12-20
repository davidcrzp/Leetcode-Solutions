char* convert(char* s, int numRows) {
    if(numRows == 1) return s;
    char* result = strdup(s);
    int length = strlen(s), indx = 0;
    for(int i = 0; i < numRows; i++) {
        for(int j = i; j < length; j+=numRows*2-2) {
            result[indx++] = s[j];
            if(!(i == 0 || i == numRows-1) && j + (numRows*2-(2*i+2)) < length)
                result[indx++] = s[j + (numRows*2-(2*i+2))];
        }
    }
    return result;
}
