public class Solution {
    public int FindDuplicate(int[] nums) {
        int ans = 0;
        for(int i=0; i<nums.Length; i++){
            int ele = nums[i];
            ele = Math.Abs(ele);
            if(nums[ele]>0){
                nums[ele]=-nums[ele];
            }
            else{
                ans = ele;
                break;
            }
        }

        for(int i = 0; i<nums.Length; i++){
            nums[i]=Math.Abs(nums[i]);
        }

        return ans;
    }
}