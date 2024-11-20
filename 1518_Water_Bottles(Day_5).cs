public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int ans = numBottles;
        while(numBottles >= numExchange){
            int newBottles = numBottles/numExchange;
            int remainder = numBottles%numExchange;
            ans+=newBottles;
            numBottles = newBottles+remainder;
        }
        return ans; 
    }
}