// Recursion
bool isPowerOfTwo(int n) {
    if(n == 1)
        return true;
        
    if(n % 2 != 0 || n < 1) 
        return false;

    return isPowerOfTwo(n / 2);
}

// While loop
bool isPowerOfTwo(int n) {
    double d = n;
    while (d > 1) d /= 2;
    return d == 1;
}
