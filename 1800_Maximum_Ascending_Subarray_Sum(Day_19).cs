public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int currentMax = nums[0];
        int max = nums[0];

        for(int i = 1; i < nums.Length; i++){
            if(nums[i-1]<nums[i]){
                currentMax = currentMax + nums[i];
            }
            else{
                max = Math.Max(currentMax,max);
                currentMax = nums[i];
            }
        }
        max = Math.Max(currentMax,max);
        return max;
        
    }
}