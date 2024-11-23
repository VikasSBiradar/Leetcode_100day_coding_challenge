public class Solution {
    public int MaxProduct(int[] nums) {
        int max = -1, secondMax = -1;

        for(int i = 0; i<nums.Length; i++){
            if(nums[i] > max){
                secondMax = max;
                max = nums[i];
            }
            else if(nums[i]>secondMax){
                secondMax = nums[i];
            }
        }
        return (max - 1) * (secondMax - 1);
    }
}