public class Solution {
    public int PivotIndex(int[] nums) {
        int rsum  = 0;

        foreach(var ele in nums){
            rsum+=ele;
        }

        int lsum=0;

        for(int i =0;i<nums.Length;i++){
            rsum-=nums[i];
            if(lsum==rsum){
                return i;
            }
            lsum+=nums[i];
        }

        return -1;
    }
}