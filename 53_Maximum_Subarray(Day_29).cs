public class Solution {
    public int MaxSubArray(int[] nums) {
        //Kandanes Algorithm
        int currentSum = nums[0];
        int maxSum = nums[0];
        for(int i = 1; i<nums.Length; i++){
            if(currentSum + nums[i]>nums[i]){
                currentSum+=nums[i];
            }
            else{
                currentSum = nums[i];
            }
            maxSum = Math.Max(currentSum,maxSum);
        }
        return maxSum;
    }
}