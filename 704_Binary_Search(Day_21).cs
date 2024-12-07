public class Solution {
    public int Search(int[] nums, int target) {
            int start = 0;
            int end = nums.Length - 1;
            while(start <=end){
                int mid = (start + end)/2;
                if(nums[mid] == target){
                    return mid;
                }
                else if(target > nums[mid]){
                    start = mid+1;
                }
                else{
                    end = mid-1;
                }
            }
            return -1;
    }
}