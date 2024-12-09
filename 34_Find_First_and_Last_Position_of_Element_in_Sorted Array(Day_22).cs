public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] indexes = new int[2];

        indexes[0]=-1;
        indexes[1]=-1;

        for(int i=0; i<nums.Length; i++){
            if(nums[i]==target){
                if(indexes[0] == -1){
                    indexes[0]=i;
                }
                indexes[1]=i;
            }
            
        }
        return indexes;
        
    }
}