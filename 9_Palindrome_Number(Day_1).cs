public class Solution {
    public bool IsPalindrome(int x) {
        int reverse = 0, remainder = 0, original; 
        if(x < 0){
            return false;
        }
        original = x;
        while(x != 0){
            remainder = x%10;
            reverse = reverse * 10 + remainder;
            x = x/10;
        }
        if(reverse == original){
            return true;
        }
        else{
            return false;
        }
    }
}