// Recursion
bool isPowerOfThree(int n) {
    if(n == 1)
        return true;

    if(n % 3 != 0 || n < 1) 
        return false;

    return isPowerOfThree(n / 3);
}

// While loop
bool isPowerOfThree(int n) {
    double d = n;
    while (d > 1) d /= 3;
    return d == 1;
}
