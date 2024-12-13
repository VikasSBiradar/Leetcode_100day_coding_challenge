public class Solution {
    public int FindPeakElement(int[] nums) {
        if(nums.Length == 1){
            return 0;
        }
        else if(nums[0]>nums[1]){
            return 0;
        }
        else if(nums[nums.Length-1] > nums[nums.Length-2]){
            return nums.Length-1;
        }
        else{
            int start = 1;
            int end = nums.Length-2;

            while(start <= end){
                int mid = start + (end - start) / 2;

                 if(nums[mid]>nums[mid-1] && nums[mid]>nums[mid+1]){
                  return mid;
                 }
                 else if(nums[mid]<nums[mid+1]){
                    start = mid+1;
                 }
                else{
                   end = mid-1;
                }
            }
            return -1;
        }
    }
}