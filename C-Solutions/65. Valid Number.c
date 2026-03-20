bool isNumber(char* s) {
    if(s[1] != NULL && isdigit(s[1]) == 0) {
        if(!(s[1] == '.' || tolower(s[1]) == 'e')) {
            return false;
        }
    }
    char *ePtr;
    double d = strtold(s, &ePtr);
    if(ePtr[0] == NULL) return true;
    else return false;
}
