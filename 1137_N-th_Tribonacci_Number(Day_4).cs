public class Solution {
    public int Tribonacci(int n) {
         if(n == 0 || n == 1){
            return n;
        }
        else if(n==2){
            return 1;
        }
        else{
            int firstTerm = 0;
            int secondTerm = 1;
            int thirdTerm = 1;
            for(int i = 0; i <n; i++){
                int fourthTerm = firstTerm + secondTerm + thirdTerm;
                firstTerm = secondTerm;
                secondTerm = thirdTerm;
                thirdTerm = fourthTerm;
            }
            return firstTerm;
        }
    }
}