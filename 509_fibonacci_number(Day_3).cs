class Solution {
public:
    int fib(int n) {
        int n1 = 0;
        int n2 = 1;
        if( n == 0 || n == 1){
          return n;
        }
        else{
            return fib(n-1)+fib(n-2);
        }
    }
};