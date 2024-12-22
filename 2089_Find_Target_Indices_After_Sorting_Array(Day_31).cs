public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        int targetCount = 0;
        int countOfElementSmallerThanTargetElement = 0;
        int numsLength = nums.Length;
        for(int i = 0; i < numsLength; i++){
            if(nums[i]==target){
                targetCount++;
            }
        }

        for(int i = 0; i< numsLength; i++){
                if(nums[i]<target){
                    countOfElementSmallerThanTargetElement++;
                }
        }

        int[] indices = new int[targetCount];
        for(int i = 0; i<targetCount; i++){
            indices[i]=countOfElementSmallerThanTargetElement;
            countOfElementSmallerThanTargetElement++;
        }
         return indices;
    }
}