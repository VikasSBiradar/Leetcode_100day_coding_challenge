public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first = Int32.MaxValue;
        int second = Int32.MaxValue;
        int third = Int32.MaxValue;

        for(int i = 0; i < nums.Length; i++){
            int ele = nums[i];

            if(first>=ele){
                first = ele;
            }
            else if(second>=ele){
                second = ele;
            }
            else{
                third = ele;
                return true;
            }
        }
        return false;
        
    }
}