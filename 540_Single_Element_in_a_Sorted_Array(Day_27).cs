public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        if(nums.Length == 1){
            return nums[0];
        }
        else if(nums[0]!=nums[1]){
            return nums[0];
        }
        else if(nums[nums.Length-1] != nums[nums.Length-2]){
            return nums[nums.Length-1];
        }
        else{
            int start = 0;
            int end = nums.Length-1;

            while(start <= end){
                int mid = start + (end-start)/2;

                if(nums[mid-1] != nums[mid] && nums[mid+1] != nums[mid]){
                    return nums[mid];
                }
                else if(mid % 2 == 1){
                    if(nums[mid-1]==nums[mid]){
                        start = mid + 1;
                    }
                    else {
                        end = mid - 1;
                    }
                }
                else{
                    if(nums[mid] == nums[mid+1]){
                        start = mid+1;
                    }
                    else{
                        end = mid-1;
                    }
                }
               
            }
        }
        return -1;
    }
}