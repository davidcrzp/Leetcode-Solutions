// Recursion
bool isPowerOfFour(int n) {
    if(n == 1)
        return true;

    if(n % 4 != 0 || n < 1) 
        return false;

    return isPowerOfFour(n / 4);
}

// While loop
bool isPowerOfFour(int n) {
    double d = n;
    while (d > 1) d /= 4;
    return d == 1;
}
