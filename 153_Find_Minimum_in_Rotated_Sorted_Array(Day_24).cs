public class Solution {
    public int FindMin(int[] nums) {
        if(nums.Length == 1){
            return nums[0];
        }
        else if (nums[0] < nums[nums.Length-1]){
            return nums[0];
        }
        
        int start = 0;
        int end = nums.Length - 1;

        while(start <=end){
            int mid = start + (end - start) / 2;

            if(mid != 0 && nums[mid-1] > nums[mid]){
                return nums[mid];
            }
            else if(mid != nums.Length - 1 && nums[mid]>nums[mid + 1]){
                return nums[mid+1];
            }
            else if(nums[start]<=nums[mid]){
                start = mid+1;
            }
            else {
                end = mid-1;
            }

        }
        return -1;
    }
}