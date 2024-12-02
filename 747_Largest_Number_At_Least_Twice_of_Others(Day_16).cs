public class Solution {
    public int DominantIndex(int[] nums) {
        int index = -1;
        int max = -1;
        int smax = -1;
        for(int i = 0; i<nums.Length; i++){
                if(max < nums[i]){
                    smax = max;
                    max = nums[i];
                    index = i; 
                }
                else if(smax < nums[i]){
                    smax = nums[i];
                }
        }
        if(smax*2<=max){
            return index;
        }
        return -1;
    }
}