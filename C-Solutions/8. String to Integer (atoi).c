int myAtoi(char* s) {
    long l = strtol(s, NULL, 10);
    if(l > INT_MAX) {
        return INT_MAX;
    } else if(l < INT_MIN) {
        return INT_MIN;
    }
    return (int)l;
}
