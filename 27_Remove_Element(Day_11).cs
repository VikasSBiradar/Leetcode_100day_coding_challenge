public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int ptr = 0;

        for(int i = 0 ; i < nums.Length; i++){
            if(nums[i]!=val){
                nums[ptr]=nums[i];
                ptr++;
            }
        }
        return ptr;
    }
}